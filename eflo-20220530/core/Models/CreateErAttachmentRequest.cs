// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo20220530.Models
{
    public class CreateErAttachmentRequest : TeaModel {
        /// <summary>
        /// <para>Indicates whether to automatically receive all routes from all instances under the Lingjun HUB. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: received automatically.</description></item>
        /// <item><description><b>false</b>: Not received.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoReceiveAllRoute")]
        [Validation(Required=false)]
        public bool? AutoReceiveAllRoute { get; set; }

        /// <summary>
        /// <para>The name of the network instance connection.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>er-attachemnt-vpd-xksd2obl</para>
        /// </summary>
        [NameInMap("ErAttachmentName")]
        [Validation(Required=false)]
        public string ErAttachmentName { get; set; }

        /// <summary>
        /// <para>Lingjun HUB ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>er-kkopgtne</para>
        /// </summary>
        [NameInMap("ErId")]
        [Validation(Required=false)]
        public string ErId { get; set; }

        /// <summary>
        /// <para>The ID of the network instance. Valid values: <b>VPD</b> and <b>VCC</b>.</para>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/444430.html">What is Lingjun?</a></para>
        /// <para>You can query <b>Lingjun CIDR Block</b> and <b>Lingjun Connection</b> by <a href="https://help.aliyun.com/document_detail/2331077.html">ListVpds</a> and <a href="https://help.aliyun.com/document_detail/2399526.html?">ListVccs</a> respectively.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpd-xksd2obl</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The category of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>VPD</b>: indicates the Lingjun CIDR block.</description></item>
        /// <item><description><b>VCC</b>: indicates a Lingjun connection.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VPD</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-wulanchabu</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the tenant to which the resource belongs. This parameter is required for cross-account resources.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1620939556166277</para>
        /// </summary>
        [NameInMap("ResourceTenantId")]
        [Validation(Required=false)]
        public string ResourceTenantId { get; set; }

    }

}
