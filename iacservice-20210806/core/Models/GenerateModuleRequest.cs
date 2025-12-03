// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class GenerateModuleRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Resource</para>
        /// </summary>
        [NameInMap("generateSource")]
        [Validation(Required=false)]
        public string GenerateSource { get; set; }

        [NameInMap("parameters")]
        [Validation(Required=false)]
        public Dictionary<string, object> Parameters { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>terraform</para>
        /// </summary>
        [NameInMap("syntax")]
        [Validation(Required=false)]
        public string Syntax { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>generateSource ==</para>
        /// </summary>
        [NameInMap("template")]
        [Validation(Required=false)]
        public string Template { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1.189.0</para>
        /// </summary>
        [NameInMap("terraformProviderVersion")]
        [Validation(Required=false)]
        public string TerraformProviderVersion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>alicloud_db_instance</para>
        /// </summary>
        [NameInMap("terraformResourceType")]
        [Validation(Required=false)]
        public string TerraformResourceType { get; set; }

    }

}
