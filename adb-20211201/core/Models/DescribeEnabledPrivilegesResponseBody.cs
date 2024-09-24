// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeEnabledPrivilegesResponseBody : TeaModel {
        /// <summary>
        /// <para>The queried permission level and permissions.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeEnabledPrivilegesResponseBodyData> Data { get; set; }
        public class DescribeEnabledPrivilegesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The description of the permission level.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The queried permissions.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("Privileges")]
            [Validation(Required=false)]
            public List<DescribeEnabledPrivilegesResponseBodyDataPrivileges> Privileges { get; set; }
            public class DescribeEnabledPrivilegesResponseBodyDataPrivileges : TeaModel {
                /// <summary>
                /// <para>The description of the permission.</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The name of the permission.</para>
                /// 
                /// <b>Example:</b>
                /// <para>select</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

            }

            /// <summary>
            /// <para>The permission level.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Global</para>
            /// </summary>
            [NameInMap("Scope")]
            [Validation(Required=false)]
            public string Scope { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>246F42E0-A475-15FF-96D2-8DC47FC2F289</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
