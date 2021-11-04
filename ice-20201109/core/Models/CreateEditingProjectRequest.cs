// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class CreateEditingProjectRequest : TeaModel {
        /// <summary>
        /// 工程业务配置。如果是直播剪辑工程必填OutputMediaConfig.StorageLocation,   Path 不填默认合成的直播片段存储在根路径下 OutputMediaTarget 不填默认oss-object，可以填vod-media 表示存储到vod  OutputMediaTarget 为vod-media 时，Path不生效。
        /// </summary>
        [NameInMap("BusinessConfig")]
        [Validation(Required=false)]
        public string BusinessConfig { get; set; }

        /// <summary>
        /// 云剪辑工程封面
        /// </summary>
        [NameInMap("CoverURL")]
        [Validation(Required=false)]
        public string CoverURL { get; set; }

        /// <summary>
        /// 云剪辑工程描述
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// 工程关联素材，多个素材以逗号（,）分隔；每种类型最多支持10个素材ID
        /// </summary>
        [NameInMap("MaterialMaps")]
        [Validation(Required=false)]
        public string MaterialMaps { get; set; }

        /// <summary>
        /// 剪辑工程类型，EditingProject: 普通剪辑工程；LiveEditingProject: 直播剪辑工程
        /// </summary>
        [NameInMap("ProjectType")]
        [Validation(Required=false)]
        public string ProjectType { get; set; }

        /// <summary>
        /// 云剪辑工程时间线，Json格式
        /// </summary>
        [NameInMap("Timeline")]
        [Validation(Required=false)]
        public string Timeline { get; set; }

        /// <summary>
        /// 云剪辑工程标题
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
