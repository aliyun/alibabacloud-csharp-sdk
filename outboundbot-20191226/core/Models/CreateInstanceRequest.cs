// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class CreateInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The list of calling numbers.</para>
        /// <remarks>
        /// <para>This parameter is optional.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("CallingNumber")]
        [Validation(Required=false)]
        public List<string> CallingNumber { get; set; }

        /// <summary>
        /// <para>The description of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>这个是第一的实例</para>
        /// </summary>
        [NameInMap("InstanceDescription")]
        [Validation(Required=false)]
        public string InstanceDescription { get; set; }

        /// <summary>
        /// <para>The name of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>第一个实例</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The maximum number of concurrent conversations for the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("MaxConcurrentConversation")]
        [Validation(Required=false)]
        public int? MaxConcurrentConversation { get; set; }

        /// <summary>
        /// <para>The service type.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the default value is Managed.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>DialogStudio: Conversation Engine 3.0.</para>
        /// </description></item>
        /// <item><description><para>Authorized: A chatbot for the public cloud. This value is used when a public cloud customer purchases a private Intelligent Speech Interaction service and grants authorization. To grant authorization, go to Scenario Management, click Edit, and then select Custom Service in the Invoke Service section.</para>
        /// </description></item>
        /// <item><description><para>Provided: A chatbot for on-premises deployment.</para>
        /// </description></item>
        /// <item><description><para>Managed: The legacy outbound call canvas. This is the default public Intelligent Speech Interaction service for the outbound call product.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DialogStudio</para>
        /// </summary>
        [NameInMap("NluServiceType")]
        [Validation(Required=false)]
        public string NluServiceType { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// <remarks>
        /// <para>You can call the ListResourceGroups operation to obtain this ID. For more information, see the Resource Management documentation at https\://api.aliyun.com/document/ResourceManager/2020-03-31/ListResourceGroups</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmwd4qr3z773y</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
