// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class TransformerForView : TeaModel {
        [NameInMap("actions")]
        [Validation(Required=false)]
        public List<TransformAction> Actions { get; set; }

        [NameInMap("createTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        [NameInMap("filterSetting")]
        [Validation(Required=false)]
        public FilterSetting FilterSetting { get; set; }

        [NameInMap("quitAfterMatch")]
        [Validation(Required=false)]
        public bool? QuitAfterMatch { get; set; }

        [NameInMap("sortId")]
        [Validation(Required=false)]
        public int? SortId { get; set; }

        [NameInMap("transformerId")]
        [Validation(Required=false)]
        public string TransformerId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("transformerName")]
        [Validation(Required=false)]
        public string TransformerName { get; set; }

        [NameInMap("updateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
