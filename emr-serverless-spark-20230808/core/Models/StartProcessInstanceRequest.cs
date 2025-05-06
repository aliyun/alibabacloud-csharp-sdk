// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class StartProcessInstanceRequest : TeaModel {
        [NameInMap("action")]
        [Validation(Required=false)]
        public string Action { get; set; }

        [NameInMap("comments")]
        [Validation(Required=false)]
        public string Comments { get; set; }

        [NameInMap("email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        [NameInMap("interval")]
        [Validation(Required=false)]
        public string Interval { get; set; }

        /// <summary>
        /// <para>Specifies whether to run the workflow in the production environment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("isProd")]
        [Validation(Required=false)]
        public bool? IsProd { get; set; }

        /// <summary>
        /// <para>The workflow ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12***********</para>
        /// </summary>
        [NameInMap("processDefinitionCode")]
        [Validation(Required=false)]
        public long? ProcessDefinitionCode { get; set; }

        /// <summary>
        /// <para>The code of the service.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SS</para>
        /// </summary>
        [NameInMap("productNamespace")]
        [Validation(Required=false)]
        public string ProductNamespace { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The queue on which the workflow runs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>root_queue</para>
        /// </summary>
        [NameInMap("runtimeQueue")]
        [Validation(Required=false)]
        public string RuntimeQueue { get; set; }

        /// <summary>
        /// <para>The hash code of the version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dh*********</para>
        /// </summary>
        [NameInMap("versionHashCode")]
        [Validation(Required=false)]
        public string VersionHashCode { get; set; }

        /// <summary>
        /// <para>The version number of the workflow.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("versionNumber")]
        [Validation(Required=false)]
        public int? VersionNumber { get; set; }

    }

}
