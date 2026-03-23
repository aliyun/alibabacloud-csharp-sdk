// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudwifi_pop20191118.Models
{
    public class EditApgroupThirdAppRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ApgroupId")]
        [Validation(Required=false)]
        public long? ApgroupId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AppCode")]
        [Validation(Required=false)]
        public string AppCode { get; set; }

        [NameInMap("AppData")]
        [Validation(Required=false)]
        public string AppData { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        [NameInMap("ApplyToSubGroup")]
        [Validation(Required=false)]
        public int? ApplyToSubGroup { get; set; }

        [NameInMap("Category")]
        [Validation(Required=false)]
        public int? Category { get; set; }

        [NameInMap("ConfigType")]
        [Validation(Required=false)]
        public string ConfigType { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("InheritParentGroup")]
        [Validation(Required=false)]
        public int? InheritParentGroup { get; set; }

        [NameInMap("ThirdAppName")]
        [Validation(Required=false)]
        public string ThirdAppName { get; set; }

    }

}
