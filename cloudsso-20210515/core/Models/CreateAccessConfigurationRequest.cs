// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class CreateAccessConfigurationRequest : TeaModel {
        /// <summary>
        /// <para>The name of the access configuration.</para>
        /// <para>Format: contains letters, digits, or hyphens (-).</para>
        /// <para>Length: up to 32 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECS-Admin</para>
        /// </summary>
        [NameInMap("AccessConfigurationName")]
        [Validation(Required=false)]
        public string AccessConfigurationName { get; set; }

        /// <summary>
        /// <para>The description of the access configuration.</para>
        /// <para>Length: up to 1024 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is an access configuration.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The directory ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-00fc2p61****</para>
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// <para>The initial access page.</para>
        /// <para>The page address that a CloudSSO user initially accesses when using the access configuration to access an account in a resource directory.</para>
        /// <para>The page must be an Alibaba Cloud Management Console page. Default value: empty, which indicates that the user is redirected to the homepage of the Alibaba Cloud Management Console.</para>
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
        /// <para>Valid values: 900 to 43200 (15 minutes to 12 hours).</para>
        /// <para>Default value: 3600 (1 hour).</para>
        /// 
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("SessionDuration")]
        [Validation(Required=false)]
        public int? SessionDuration { get; set; }

        /// <summary>
        /// <para>The list of tags.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<CreateAccessConfigurationRequestTags> Tags { get; set; }
        public class CreateAccessConfigurationRequestTags : TeaModel {
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

    }

}
