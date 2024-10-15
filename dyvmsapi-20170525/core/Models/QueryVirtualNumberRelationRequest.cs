// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class QueryVirtualNumberRelationRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The virtual number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>05516214****</para>
        /// </summary>
        [NameInMap("PhoneNum")]
        [Validation(Required=false)]
        public string PhoneNum { get; set; }

        /// <summary>
        /// <para>The service name. Default value: <b>dyvms</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dyvms</para>
        /// </summary>
        [NameInMap("ProdCode")]
        [Validation(Required=false)]
        public string ProdCode { get; set; }

        /// <summary>
        /// <para>The qualification ID.</para>
        /// <para>You can log on to the <a href="https://dyvms.console.aliyun.com/overview/home">Voice Messaging Service console</a>, choose <b>Qualifications\&amp;Communication Scripts &gt; Qualification Management</b>, and then click <b>Details</b> in the Actions column to view the qualification ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000000542****</para>
        /// </summary>
        [NameInMap("QualificationId")]
        [Validation(Required=false)]
        public long? QualificationId { get; set; }

        /// <summary>
        /// <para>The city to which the virtual number belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hangzhou</para>
        /// </summary>
        [NameInMap("RegionNameCity")]
        [Validation(Required=false)]
        public string RegionNameCity { get; set; }

        /// <summary>
        /// <para>The real number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1705559****</para>
        /// </summary>
        [NameInMap("RelatedNum")]
        [Validation(Required=false)]
        public string RelatedNum { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The route type. Valid values:</para>
        /// <para><b>0</b>: number location first. <b>1</b>: random.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RouteType")]
        [Validation(Required=false)]
        public int? RouteType { get; set; }

        /// <summary>
        /// <para>The number type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: the number provided by a virtual network operator, in the 05710000\<em>\</em>\<em>\</em> format.</description></item>
        /// <item><description><b>2</b>: the number provided by an Internet service provider (ISP).</description></item>
        /// <item><description><b>3</b>: a 5-digit phone number that starts with 95.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SpecId")]
        [Validation(Required=false)]
        public long? SpecId { get; set; }

    }

}
