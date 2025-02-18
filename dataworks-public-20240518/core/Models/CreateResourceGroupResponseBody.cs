// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateResourceGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request. It is used to locate logs and troubleshoot problems.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6A6CBE87-9F91-1323-B680-E7A7065XXXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The order information for creating a serverless resource group.</para>
        /// </summary>
        [NameInMap("ResourceGroupOrder")]
        [Validation(Required=false)]
        public CreateResourceGroupResponseBodyResourceGroupOrder ResourceGroupOrder { get; set; }
        public class CreateResourceGroupResponseBodyResourceGroupOrder : TeaModel {
            /// <summary>
            /// <para>The unique identifier of the serverless resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Serverless_res_group_524257424564736_6831777003XXXXX</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The ID of the order to create a serverless resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2391982058XXXXX</para>
            /// </summary>
            [NameInMap("OrderId")]
            [Validation(Required=false)]
            public long? OrderId { get; set; }

            /// <summary>
            /// <para>The ID of the order instance that created the serverless resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c442b330-3b10-4584-959e-736e4edXXXXX</para>
            /// </summary>
            [NameInMap("OrderInstanceId")]
            [Validation(Required=false)]
            public string OrderInstanceId { get; set; }

        }

        /// <summary>
        /// <para>Whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
