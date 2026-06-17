// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeActivationCodesRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Alibaba Cloud order (including virtual orders) used to purchase the activation codes.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2233****445566</para>
        /// </summary>
        [NameInMap("AliyunOrderId")]
        [Validation(Required=false)]
        public string AliyunOrderId { get; set; }

        /// <summary>
        /// <para>Filters the list to return only the activation code matching the specified MAC address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aa:bb:cc:dd:ee:ff</para>
        /// </summary>
        [NameInMap("MacAddress")]
        [Validation(Required=false)]
        public string MacAddress { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>Page number</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>Number of records to return per page</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>Filters the list to return only the activation code matching the specified system identifier.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3312548696141831911</para>
        /// </summary>
        [NameInMap("SystemIdentifier")]
        [Validation(Required=false)]
        public string SystemIdentifier { get; set; }

    }

}
