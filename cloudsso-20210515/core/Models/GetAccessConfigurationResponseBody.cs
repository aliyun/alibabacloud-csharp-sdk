// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class GetAccessConfigurationResponseBody : TeaModel {
        /// <summary>
        /// <para>The access configuration information.</para>
        /// </summary>
        [NameInMap("AccessConfiguration")]
        [Validation(Required=false)]
        public GetAccessConfigurationResponseBodyAccessConfiguration AccessConfiguration { get; set; }
        public class GetAccessConfigurationResponseBodyAccessConfiguration : TeaModel {
            /// <summary>
            /// <para>The access configuration ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ac-00ccule7tadaijxc****</para>
            /// </summary>
            [NameInMap("AccessConfigurationId")]
            [Validation(Required=false)]
            public string AccessConfigurationId { get; set; }

            /// <summary>
            /// <para>The name of the access configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>VPC-Admin</para>
            /// </summary>
            [NameInMap("AccessConfigurationName")]
            [Validation(Required=false)]
            public string AccessConfigurationName { get; set; }

            /// <summary>
            /// <para>The time when the access configuration was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-06-30T09:39:44Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the access configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>This is an access configuration.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The initial access page.</para>
            /// <para>The URL of the initial page that is displayed when a CloudSSO user uses the access configuration to access an account in a resource directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://cloudsso.console.aliyun.com">https://cloudsso.console.aliyun.com</a></para>
            /// </summary>
            [NameInMap("RelayState")]
            [Validation(Required=false)]
            public string RelayState { get; set; }

            /// <summary>
            /// <para>The session duration.</para>
            /// <para>The maximum duration of a session when a CloudSSO user uses the access configuration to access an account in a resource directory.</para>
            /// <para>Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3600</para>
            /// </summary>
            [NameInMap("SessionDuration")]
            [Validation(Required=false)]
            public int? SessionDuration { get; set; }

            /// <summary>
            /// <para>The status notification information.</para>
            /// </summary>
            [NameInMap("StatusNotifications")]
            [Validation(Required=false)]
            public List<string> StatusNotifications { get; set; }

            /// <summary>
            /// <para>The tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<GetAccessConfigurationResponseBodyAccessConfigurationTags> Tags { get; set; }
            public class GetAccessConfigurationResponseBodyAccessConfigurationTags : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TestKey</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TestValue</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The time when the access configuration was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-07-26T03:02:11Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D5E40508-483B-52F6-993C-D880B0F87591</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
