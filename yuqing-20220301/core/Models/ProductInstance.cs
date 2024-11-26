// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yuqing20220301.Models
{
    public class ProductInstance : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EUWYEEQ</para>
        /// </summary>
        [NameInMap("appCode")]
        [Validation(Required=false)]
        public string AppCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("buyerName")]
        [Validation(Required=false)]
        public string BuyerName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ID2343231321</para>
        /// </summary>
        [NameInMap("buyerUid")]
        [Validation(Required=false)]
        public string BuyerUid { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALIYUN</para>
        /// </summary>
        [NameInMap("channel")]
        [Validation(Required=false)]
        public string Channel { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1640292843231</para>
        /// </summary>
        [NameInMap("end")]
        [Validation(Required=false)]
        public long? End { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ID3928389103844</para>
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D23938474923u42</para>
        /// </summary>
        [NameInMap("orderNo")]
        [Validation(Required=false)]
        public string OrderNo { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C394884</para>
        /// </summary>
        [NameInMap("productCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C847573</para>
        /// </summary>
        [NameInMap("productSpecCode")]
        [Validation(Required=false)]
        public string ProductSpecCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1640292843231</para>
        /// </summary>
        [NameInMap("start")]
        [Validation(Required=false)]
        public long? Start { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>XXX</para>
        /// </summary>
        [NameInMap("tenantName")]
        [Validation(Required=false)]
        public string TenantName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UID284747383</para>
        /// </summary>
        [NameInMap("tenantUid")]
        [Validation(Required=false)]
        public string TenantUid { get; set; }

    }

}
