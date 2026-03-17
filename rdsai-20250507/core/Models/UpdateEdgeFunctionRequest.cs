// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class UpdateEdgeFunctionRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>ETnLKlblzczshOTUbOCz****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public UpdateEdgeFunctionRequestCode Code { get; set; }
        public class UpdateEdgeFunctionRequestCode : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>code</para>
            /// </summary>
            [NameInMap("OssBucketName")]
            [Validation(Required=false)]
            public string OssBucketName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>example2.zip</para>
            /// </summary>
            [NameInMap("OssObjectName")]
            [Validation(Required=false)]
            public string OssObjectName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>supabase</para>
            /// </summary>
            [NameInMap("OssType")]
            [Validation(Required=false)]
            public string OssType { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("CustomConfig")]
        [Validation(Required=false)]
        public Dictionary<string, object> CustomConfig { get; set; }

        /// <summary>
        /// <para>fc-xxxx。</para>
        /// 
        /// <b>Example:</b>
        /// <para>ef-****</para>
        /// </summary>
        [NameInMap("EdgeFunctionName")]
        [Validation(Required=false)]
        public string EdgeFunctionName { get; set; }

        [NameInMap("Envs")]
        [Validation(Required=false)]
        public Dictionary<string, string> Envs { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ra-supabase-8moov5lxba****</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
