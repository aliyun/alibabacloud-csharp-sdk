// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListAuthorizedInstancesForUserResponseBody : TeaModel {
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<ListAuthorizedInstancesForUserResponseBodyInstances> Instances { get; set; }
        public class ListAuthorizedInstancesForUserResponseBodyInstances : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>MySQL</para>
            /// </summary>
            [NameInMap("DbType")]
            [Validation(Required=false)]
            public string DbType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>product</para>
            /// </summary>
            [NameInMap("EnvType")]
            [Validation(Required=false)]
            public string EnvType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>rm-2zex9lrc0gz0****.mysql.rds.aliyuncs.com</para>
            /// </summary>
            [NameInMap("Host")]
            [Validation(Required=false)]
            public string Host { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>DMS_TEST</para>
            /// </summary>
            [NameInMap("InstanceAlias")]
            [Validation(Required=false)]
            public string InstanceAlias { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>21****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("PermissionDetail")]
            [Validation(Required=false)]
            public ListAuthorizedInstancesForUserResponseBodyInstancesPermissionDetail PermissionDetail { get; set; }
            public class ListAuthorizedInstancesForUserResponseBodyInstancesPermissionDetail : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>DATABASE</para>
                /// </summary>
                [NameInMap("DsType")]
                [Validation(Required=false)]
                public string DsType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-12-06 10:00:00</para>
                /// </summary>
                [NameInMap("ExpireDate")]
                [Validation(Required=false)]
                public string ExpireDate { get; set; }

                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>CORRECT</para>
                /// </summary>
                [NameInMap("PermType")]
                [Validation(Required=false)]
                public string PermType { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3306</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>51****</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>user_test</para>
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>B7DB89CC-017D-5503-8953-38FFE241A618</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
