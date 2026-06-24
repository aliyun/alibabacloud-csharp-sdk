// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ModifyAppInstanceGroupAttributeShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The delivery group ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aig-9ciijz60n4xsv****</para>
        /// </summary>
        [NameInMap("AppInstanceGroupId")]
        [Validation(Required=false)]
        public string AppInstanceGroupId { get; set; }

        /// <summary>
        /// <para>The delivery group name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>办公应用</para>
        /// </summary>
        [NameInMap("AppInstanceGroupName")]
        [Validation(Required=false)]
        public string AppInstanceGroupName { get; set; }

        /// <summary>
        /// <para>The network configuration.</para>
        /// <remarks>
        /// <para>To use this parameter, submit a ticket.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Network")]
        [Validation(Required=false)]
        public string NetworkShrink { get; set; }

        /// <summary>
        /// <para>The resource group object.</para>
        /// </summary>
        [NameInMap("NodePool")]
        [Validation(Required=false)]
        public string NodePoolShrink { get; set; }

        /// <summary>
        /// <para>Specifies whether to allow only one application per session.</para>
        /// <list type="bullet">
        /// <item><description>If enabled, opening multiple applications within a delivery group allocates a separate session for each application, consuming more sessions.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("PerSessionPerApp")]
        [Validation(Required=false)]
        public bool? PerSessionPerApp { get; set; }

        /// <summary>
        /// <para>The AppId of the pre-open application. If the PreOpenMode parameter is set to <c>SINGLE_APP</c>, PreOpenAppId cannot be an empty string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ca-b2ronxxd****</para>
        /// </summary>
        [NameInMap("PreOpenAppId")]
        [Validation(Required=false)]
        public string PreOpenAppId { get; set; }

        /// <summary>
        /// <para>The pre-open mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OFF</para>
        /// </summary>
        [NameInMap("PreOpenMode")]
        [Validation(Required=false)]
        public string PreOpenMode { get; set; }

        /// <summary>
        /// <para>The product type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CloudApp</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// <para>The security policy.</para>
        /// </summary>
        [NameInMap("SecurityPolicy")]
        [Validation(Required=false)]
        public string SecurityPolicyShrink { get; set; }

        /// <summary>
        /// <para>The session retention duration after disconnection, in minutes. After an end user session is disconnected, the session is retained for the specified duration before being logged off. Set this parameter to <c>-1</c> to retain the session indefinitely. Valid values: -1 and 3 to 300. Default value: <c>15</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("SessionTimeout")]
        [Validation(Required=false)]
        public int? SessionTimeout { get; set; }

        /// <summary>
        /// <para>The storage policy.</para>
        /// </summary>
        [NameInMap("StoragePolicy")]
        [Validation(Required=false)]
        public string StoragePolicyShrink { get; set; }

    }

}
