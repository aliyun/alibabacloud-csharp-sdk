// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo20220530.Models
{
    public class GetErAttachmentResponseBody : TeaModel {
        /// <summary>
        /// <para>The response status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public GetErAttachmentResponseBodyContent Content { get; set; }
        public class GetErAttachmentResponseBodyContent : TeaModel {
            /// <summary>
            /// <para>Whether cross-account. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: The network instance is a cross-account resource.</description></item>
            /// <item><description><b>false</b>: The current network instance is a resource of the current account.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>fasle</para>
            /// </summary>
            [NameInMap("Across")]
            [Validation(Required=false)]
            public bool? Across { get; set; }

            /// <summary>
            /// <para>Indicates whether to automatically receive all routes from all instances under the Lingjun HUB. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: received automatically.</description></item>
            /// <item><description><b>false</b>: Not received.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AutoReceiveAllRoute")]
            [Validation(Required=false)]
            public bool? AutoReceiveAllRoute { get; set; }

            /// <summary>
            /// <para>The time when the activation code was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1648085472000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The ID of the Lingjun HUB network instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>er-attachment-i1ioibyf</para>
            /// </summary>
            [NameInMap("ErAttachmentId")]
            [Validation(Required=false)]
            public string ErAttachmentId { get; set; }

            /// <summary>
            /// <para>The name of the Lingjun HUB network instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpd-lxnsj2cx</para>
            /// </summary>
            [NameInMap("ErAttachmentName")]
            [Validation(Required=false)]
            public string ErAttachmentName { get; set; }

            /// <summary>
            /// <para>The ID of the Lingjun HUB instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>er-aueyxxsy</para>
            /// </summary>
            [NameInMap("ErId")]
            [Validation(Required=false)]
            public string ErId { get; set; }

            /// <summary>
            /// <para>The time when the O\&amp;M task was modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1648085472000</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The ID of the network instance. Valid values: <b>VPD</b> and <b>VCC</b>.</para>
            /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/444430.html">What is Lingjun?</a></para>
            /// <para>You can query <b>Lingjun CIDR blocks</b> and <b>Lingjun connections</b> by <a href="https://help.aliyun.com/document_detail/2331077.html">ListVpds</a> and <a href="https://help.aliyun.com/document_detail/2399526.html?">ListVccs</a> respectively.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpd-lxnsj2cx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The instance name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpd-wulanchabu-main</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The database type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>VPD</b>: indicates the Lingjun CIDR block.</description></item>
            /// <item><description><b>VCC</b>: indicates a Lingjun connection.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>VPD</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>The returned message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-wulanchabu</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>Resource group instance ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-aekzb3n5lgk2ieq</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The ID of the tenant to which the resource belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1620939556166277</para>
            /// </summary>
            [NameInMap("ResourceTenantId")]
            [Validation(Required=false)]
            public string ResourceTenantId { get; set; }

            /// <summary>
            /// <para>The status of the cache reserve instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Available</b>: Normal.</description></item>
            /// <item><description><b>Not Available</b>: Not available.</description></item>
            /// <item><description><b>Executing</b>: The task is being executed.</description></item>
            /// <item><description><b>Deleting</b>: The account is being deleted</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Available</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The tenant ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1655449505171</para>
            /// </summary>
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

        /// <summary>
        /// <para>The error message. (If the instance is in the Exception state, the exception cause is displayed.)</para>
        /// 
        /// <b>Example:</b>
        /// <para>You don\&quot;t have the permission to do this operation.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7F0D9440-1F97-5613-87CD-D3047172A93C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
