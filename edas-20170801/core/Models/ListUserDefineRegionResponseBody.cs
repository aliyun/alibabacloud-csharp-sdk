// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListUserDefineRegionResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The additional information that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b197-40ab-9155-****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The namespaces.</para>
        /// </summary>
        [NameInMap("UserDefineRegionList")]
        [Validation(Required=false)]
        public ListUserDefineRegionResponseBodyUserDefineRegionList UserDefineRegionList { get; set; }
        public class ListUserDefineRegionResponseBodyUserDefineRegionList : TeaModel {
            [NameInMap("UserDefineRegionEntity")]
            [Validation(Required=false)]
            public List<ListUserDefineRegionResponseBodyUserDefineRegionListUserDefineRegionEntity> UserDefineRegionEntity { get; set; }
            public class ListUserDefineRegionResponseBodyUserDefineRegionListUserDefineRegionEntity : TeaModel {
                /// <summary>
                /// <para>The ID of the region to which the namespace belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-shenzhen</para>
                /// </summary>
                [NameInMap("BelongRegion")]
                [Validation(Required=false)]
                public string BelongRegion { get; set; }

                /// <summary>
                /// <para>Indicates whether remote debugging is allowed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("DebugEnable")]
                [Validation(Required=false)]
                public bool? DebugEnable { get; set; }

                /// <summary>
                /// <para>The description of the namespace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>betaappManager</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The unique identifier of the namespace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1330</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The type of the registry. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>default: shared service registry of Enterprise Distributed Application Service (EDAS)</description></item>
                /// <item><description>exclusive_mse: Microservices Engine (MSE) Nacos registry</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>default: EDAS</para>
                /// </summary>
                [NameInMap("MseInstanceId")]
                [Validation(Required=false)]
                public string MseInstanceId { get; set; }

                /// <summary>
                /// <para>The ID of the namespace.</para>
                /// <remarks>
                /// <para>The ID cannot be changed after the namespace is created. The ID is in the <c>Physical region ID:Logical region identifier</c> format .</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>cn-shenzhen:betaappManager</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The name of the namespace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>betaappManager</para>
                /// </summary>
                [NameInMap("RegionName")]
                [Validation(Required=false)]
                public string RegionName { get; set; }

                /// <summary>
                /// <para>The ID of the MSE instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mse_prepaid_public_cn-tl32n******</para>
                /// </summary>
                [NameInMap("RegistryType")]
                [Validation(Required=false)]
                public string RegistryType { get; set; }

                /// <summary>
                /// <para>The ID of the Alibaba Cloud account to which the namespace belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>edas_****_test@aliyun-****.com</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

        }

    }

}
