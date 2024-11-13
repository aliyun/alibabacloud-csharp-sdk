// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class DescribeRdStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The Alibaba Cloud account ID of the current account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>125085778340****</para>
        /// </summary>
        [NameInMap("CurrentUid")]
        [Validation(Required=false)]
        public string CurrentUid { get; set; }

        /// <summary>
        /// <para>The type of the Alibaba Cloud account. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>MasterAccount</b>: management account</description></item>
        /// <item><description><b>DelegatedAdminAccount</b>: delegated administrator account</description></item>
        /// <item><description><b>MasterAccount</b>: member</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MemberAccount</para>
        /// </summary>
        [NameInMap("CurrentUidType")]
        [Validation(Required=false)]
        public string CurrentUidType { get; set; }

        /// <summary>
        /// <para>Indicates whether the multi-account management feature is enabled for Anti-DDoS Origin.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>Indicates whether the multi-account management feature is enabled for the current account in Anti-DDoS Origin.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("LocalEnable")]
        [Validation(Required=false)]
        public bool? LocalEnable { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud account ID of the management account in the resource directory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>125085778340****</para>
        /// </summary>
        [NameInMap("MasterUid")]
        [Validation(Required=false)]
        public string MasterUid { get; set; }

        /// <summary>
        /// <para>Indicates whether Resource Directory is enabled in the <a href="https://resourcemanager.console.aliyun.com">Resource Management console</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("RemoteEnable")]
        [Validation(Required=false)]
        public bool? RemoteEnable { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1B0F7EC6-51D7-4D70-B0EC-CD8A9E998D86</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud account ID of the management account for which the multi-account management feature is enabled in Anti-DDoS Origin.</para>
        /// 
        /// <b>Example:</b>
        /// <para>125085778340****</para>
        /// </summary>
        [NameInMap("RootUid")]
        [Validation(Required=false)]
        public string RootUid { get; set; }

        /// <summary>
        /// <para>Indicates whether the trusted service is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ServicePrincipalEnabled")]
        [Validation(Required=false)]
        public bool? ServicePrincipalEnabled { get; set; }

    }

}
