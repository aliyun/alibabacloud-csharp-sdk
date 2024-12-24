// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class StartProcessInstanceRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("isProd")]
        [Validation(Required=false)]
        public bool? IsProd { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12***********</para>
        /// </summary>
        [NameInMap("processDefinitionCode")]
        [Validation(Required=false)]
        public long? ProcessDefinitionCode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SS</para>
        /// </summary>
        [NameInMap("productNamespace")]
        [Validation(Required=false)]
        public string ProductNamespace { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>root_queue</para>
        /// </summary>
        [NameInMap("runtimeQueue")]
        [Validation(Required=false)]
        public string RuntimeQueue { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dh*********</para>
        /// </summary>
        [NameInMap("versionHashCode")]
        [Validation(Required=false)]
        public string VersionHashCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("versionNumber")]
        [Validation(Required=false)]
        public int? VersionNumber { get; set; }

    }

}
