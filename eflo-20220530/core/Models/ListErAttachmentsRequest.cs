// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo20220530.Models
{
    public class ListErAttachmentsRequest : TeaModel {
        /// <summary>
        /// <para>Whether to automatically receive all routes from all instances under this Lingjun HUB. Valid values:</para>
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
        /// <para>Specifies whether to enable paged query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enables paged query.</description></item>
        /// <item><description><b>false</b>: Paged query is not enabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnablePage")]
        [Validation(Required=false)]
        public bool? EnablePage { get; set; }

        /// <summary>
        /// <para>The ID of the network instance connection</para>
        /// 
        /// <b>Example:</b>
        /// <para>er-attachment-i1ioibyf</para>
        /// </summary>
        [NameInMap("ErAttachmentId")]
        [Validation(Required=false)]
        public string ErAttachmentId { get; set; }

        /// <summary>
        /// <para>The name of the network instance connection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vcc-cn-209300qha01</para>
        /// </summary>
        [NameInMap("ErAttachmentName")]
        [Validation(Required=false)]
        public string ErAttachmentName { get; set; }

        /// <summary>
        /// <para>The ID of the Lingjun HUB instance.</para>
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
        /// <para>You can query <b>Lingjun CIDR blocks</b> and <b>Lingjun connections</b> by <a href="https://help.aliyun.com/document_detail/2331077.html">ListVpds</a> and <a href="https://help.aliyun.com/document_detail/2399526.html?">ListVccs</a> respectively.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vcc-cn-209300qha01</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The mitigation plan of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>VPD</b>: indicates the Lingjun CIDR block.</description></item>
        /// <item><description><b>VCC</b>: indicates a Lingjun connection.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>VCC</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The page number to return. Pages start from page 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

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
        /// <para>Resource group instance ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aekzb3n5lgk2ieq</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The ID of the tenant to which the instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1111156667137893</para>
        /// </summary>
        [NameInMap("ResourceTenantId")]
        [Validation(Required=false)]
        public string ResourceTenantId { get; set; }

        /// <summary>
        /// <para>The status of the CLB instance. Valid values:</para>
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

    }

}
