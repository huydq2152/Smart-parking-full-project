﻿using Zero.Customize.Base;
using Zero.Customize.Dto.Base;

namespace DPS.Cms.Application.Shared.Dto.ImageBlock
{
	public class ImageBlockDto : SimpleEntityDto
	{
		public int ImageBlockGroupId { get; set; }
        
		public string ImageBlockGroupCode { get; set; }
		
		public string ImageBlockGroupName { get; set; }
        
		public string Image { get; set; }
        
		public string ImageMobile { get; set; }
		
		public string TargetUrl { get; set; }
	}
}