// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class UnbindSubscriptionRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The key of the phone number pool. Log on to the <a href="https://dypls.console.aliyun.com/dypls.htm#/account">Phone Number Protection console</a> and view the key of the phone number pool on the <b>Number Pool Management</b> page.</para>
        /// <remarks>
        /// <para> This parameter is required when <b>ProductType</b> is left empty.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>FC123456</para>
        /// </summary>
        [NameInMap("PoolKey")]
        [Validation(Required=false)]
        public string PoolKey { get; set; }

        /// <summary>
        /// <para>The product type. Fixed value: <b>AXB_170</b>.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter is applicable to the original key accounts of Alibaba Cloud. This parameter can be ignored for Alibaba Cloud users.</para>
        /// </description></item>
        /// <item><description><para>This parameter is required when <b>PoolKey</b> is left empty.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AXB_170</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The private number, that is, phone number X specified in an API operation for a phone number binding such as <a href="https://help.aliyun.com/document_detail/110249.html">BindAXG</a> or automatically assigned after such an operation is called.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1390000****</para>
        /// </summary>
        [NameInMap("SecretNo")]
        [Validation(Required=false)]
        public string SecretNo { get; set; }

        /// <summary>
        /// <para>The binding ID.</para>
        /// <para>Log on to the Phone Number Protection console, choose <b>Number and Number Pool</b> &gt; <b>Number Management</b>. On the Number Management page, select the desired record and click Details to view the binding ID. Alternatively, you can view the value of the <b>SubsId</b> parameter returned by an API operation for a phone number binding such as BindAxb. The value of this parameter indicates a binding ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1************2</para>
        /// </summary>
        [NameInMap("SubsId")]
        [Validation(Required=false)]
        public string SubsId { get; set; }

    }

}
