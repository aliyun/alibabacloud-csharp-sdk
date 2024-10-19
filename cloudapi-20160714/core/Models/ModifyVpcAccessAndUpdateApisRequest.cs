// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class ModifyVpcAccessAndUpdateApisRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the new instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-uf6bzcg1pr4oh5jjmxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The name of the VPC authorization.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>The name of a VPC authorization cannot be changed. You cannot use this parameter to change the name of a VPC authorization.</para>
        /// </description></item>
        /// <item><description><para>You must set this parameter to the name of the current VPC authorization.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VpcName</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Specifies whether to update the associated API.</para>
        /// <para>**</para>
        /// <para><b>Warning:</b> If you want to update the VPC authorization of a published API, you must set this parameter to true. Otherwise, the update will not be synchronized to the backend service of the API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("NeedBatchWork")]
        [Validation(Required=false)]
        public bool? NeedBatchWork { get; set; }

        /// <summary>
        /// <para>The new port number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public int? Port { get; set; }

        /// <summary>
        /// <para>Specifies whether to update the VPC authorization.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>If the ID of the instance in your VPC is changed but the IP address of the instance remains unchanged, you can set this parameter to true to update the VPC authorization.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Refresh")]
        [Validation(Required=false)]
        public bool? Refresh { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>The token of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c20d86c4-1eb3-4d0b-afe9-c586df1e2136</para>
        /// </summary>
        [NameInMap("Token")]
        [Validation(Required=false)]
        public string Token { get; set; }

        /// <summary>
        /// <para>The ID of the new VPC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-m5e7jqfppv5wbvmdw5pg2</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The hostname of the backend service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>iot.hu***ng.com</para>
        /// </summary>
        [NameInMap("VpcTargetHostName")]
        [Validation(Required=false)]
        public string VpcTargetHostName { get; set; }

    }

}
