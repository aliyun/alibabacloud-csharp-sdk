// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class UpdateUserProvisioningConfigurationRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the resource directory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-003qew84****</para>
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// <para>The new default URL for a CloudSSO user who logs on to the Alibaba Cloud Management Console.</para>
        /// <para>Default value: <a href="https://homenew.console.aliyun.com">https://homenew.console.aliyun.com</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://home.console.aliyun.com/home/dashboard/ProductAndService">https://home.console.aliyun.com/home/dashboard/ProductAndService</a></para>
        /// </summary>
        [NameInMap("NewDefaultLandingPage")]
        [Validation(Required=false)]
        public string NewDefaultLandingPage { get; set; }

        /// <summary>
        /// <para>The new duration of the logon session.</para>
        /// <para>Unit: hours.</para>
        /// <para>Valid values: 1 to 24.</para>
        /// <para>Default value: 6.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("NewSessionDuration")]
        [Validation(Required=false)]
        public int? NewSessionDuration { get; set; }

    }

}
