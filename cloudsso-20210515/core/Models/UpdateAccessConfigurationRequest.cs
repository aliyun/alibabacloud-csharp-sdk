// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class UpdateAccessConfigurationRequest : TeaModel {
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
        /// <para>The ID of the directory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-00fc2p61****</para>
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// <para>The new description of the access configuration.</para>
        /// <para>The description can be up to 1,024 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is an access configuration.</para>
        /// </summary>
        [NameInMap("NewDescription")]
        [Validation(Required=false)]
        public string NewDescription { get; set; }

        /// <summary>
        /// <para>The new initial web page that is displayed after a CloudSSO user accesses an account in your resource directory by using the access configuration.</para>
        /// <para>The web page must be a page of the Alibaba Cloud Management Console.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://cloudsso.console.aliyun.com">https://cloudsso.console.aliyun.com</a></para>
        /// </summary>
        [NameInMap("NewRelayState")]
        [Validation(Required=false)]
        public string NewRelayState { get; set; }

        /// <summary>
        /// <para>The new duration of a session in which a CloudSSO user accesses an account in your resource directory by using the access configuration.</para>
        /// <para>Unit: seconds.</para>
        /// <para>Valid values: 900 to 43200. The value 900 indicates 15 minutes. The value 43200 indicates 12 hours.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("NewSessionDuration")]
        [Validation(Required=false)]
        public int? NewSessionDuration { get; set; }

    }

}
