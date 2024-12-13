// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class CreateAccessConfigurationResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the access configuration.</para>
        /// </summary>
        [NameInMap("AccessConfiguration")]
        [Validation(Required=false)]
        public CreateAccessConfigurationResponseBodyAccessConfiguration AccessConfiguration { get; set; }
        public class CreateAccessConfigurationResponseBodyAccessConfiguration : TeaModel {
            /// <summary>
            /// <para>The ID of the access configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ac-00jhtfl8thteu6uj****</para>
            /// </summary>
            [NameInMap("AccessConfigurationId")]
            [Validation(Required=false)]
            public string AccessConfigurationId { get; set; }

            /// <summary>
            /// <para>The name of the access configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ECS-Admin</para>
            /// </summary>
            [NameInMap("AccessConfigurationName")]
            [Validation(Required=false)]
            public string AccessConfigurationName { get; set; }

            /// <summary>
            /// <para>The time when the access configuration was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-11-02T08:44:23Z</para>
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
            /// <para>The initial web page that is displayed after a CloudSSO user accesses an account in your resource directory by using the access configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://cloudsso.console.aliyun.com">https://cloudsso.console.aliyun.com</a></para>
            /// </summary>
            [NameInMap("RelayState")]
            [Validation(Required=false)]
            public string RelayState { get; set; }

            /// <summary>
            /// <para>The duration of a session in which a CloudSSO user accesses an account in your resource directory by using the access configuration.</para>
            /// <para>Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3600</para>
            /// </summary>
            [NameInMap("SessionDuration")]
            [Validation(Required=false)]
            public int? SessionDuration { get; set; }

            /// <summary>
            /// <para>The status notification.</para>
            /// </summary>
            [NameInMap("StatusNotifications")]
            [Validation(Required=false)]
            public List<string> StatusNotifications { get; set; }

            /// <summary>
            /// <para>The time when the information about the access configuration was modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-11-02T08:44:23Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A3A41736-A050-50B6-ABC5-590F376A0044</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
