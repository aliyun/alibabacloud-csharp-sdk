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
        /// <para>The name can contain letters, digits, and hyphens (-).</para>
        /// <para>The name can be up to 32 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECS-Admin</para>
        /// </summary>
        [NameInMap("AccessConfigurationName")]
        [Validation(Required=false)]
        public string AccessConfigurationName { get; set; }

        /// <summary>
        /// <para>The description of the access configuration.</para>
        /// <para>The description can be up to 1,024 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is an access configuration.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the directory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-00fc2p61****</para>
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// <para>The initial web page</para>
        /// <para>that is displayed after a CloudSSO user uses the access configuration to access an account in your resource directory.</para>
        /// <para>The web page must be a page of the Alibaba Cloud Management Console. By default, this parameter is empty, which indicates that the initial web page is the homepage of the Alibaba Cloud Management Console.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://cloudsso.console.aliyun.com">https://cloudsso.console.aliyun.com</a></para>
        /// </summary>
        [NameInMap("RelayState")]
        [Validation(Required=false)]
        public string RelayState { get; set; }

        /// <summary>
        /// <para>The duration of a session</para>
        /// <para>in which a CloudSSO user uses the access configuration to access an account in your resource directory.</para>
        /// <para>Unit: seconds.</para>
        /// <para>Valid values: 900 to 43200. The value 900 indicates 15 minutes. The value 43200 indicates 12 hours.</para>
        /// <para>Default value: 3600. The value indicates 1 hour.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("SessionDuration")]
        [Validation(Required=false)]
        public int? SessionDuration { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<CreateAccessConfigurationRequestTags> Tags { get; set; }
        public class CreateAccessConfigurationRequestTags : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
