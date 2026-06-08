// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ApplyResourceAccessPermissionRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ApplyContents")]
        [Validation(Required=false)]
        public List<ApplyResourceAccessPermissionRequestApplyContents> ApplyContents { get; set; }
        public class ApplyResourceAccessPermissionRequestApplyContents : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("AccessTypes")]
            [Validation(Required=false)]
            public List<string> AccessTypes { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ranger</para>
            /// </summary>
            [NameInMap("AuthMethod")]
            [Validation(Required=false)]
            public string AuthMethod { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1785835708000</para>
            /// </summary>
            [NameInMap("ExpirationTime")]
            [Validation(Required=false)]
            public long? ExpirationTime { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("Grantee")]
            [Validation(Required=false)]
            public ApplyResourceAccessPermissionRequestApplyContentsGrantee Grantee { get; set; }
            public class ApplyResourceAccessPermissionRequestApplyContentsGrantee : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ROLE_32237475848545</para>
                /// </summary>
                [NameInMap("PrincipalId")]
                [Validation(Required=false)]
                public string PrincipalId { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RamRole</para>
                /// </summary>
                [NameInMap("PrincipalType")]
                [Validation(Required=false)]
                public string PrincipalType { get; set; }

            }

            [NameInMap("Resource")]
            [Validation(Required=false)]
            public ApplyResourceAccessPermissionRequestApplyContentsResource Resource { get; set; }
            public class ApplyResourceAccessPermissionRequestApplyContentsResource : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MaxCompute</para>
                /// </summary>
                [NameInMap("DefSchema")]
                [Validation(Required=false)]
                public string DefSchema { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>v1.0.0</para>
                /// </summary>
                [NameInMap("DefVersion")]
                [Validation(Required=false)]
                public string DefVersion { get; set; }

                [NameInMap("MetaData")]
                [Validation(Required=false)]
                public Dictionary<string, object> MetaData { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ABFUOEUOTRTRJKE</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

    }

}
