// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeQosPoliciesRequest : TeaModel {
        /// <summary>
        /// <para>The description of the quintuple rule instance in the QoS policy.</para>
        /// <para>The description must be 1 to 512 characters in length, start with a letter or a Chinese character, and can contain digits, underscores (_), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>docdesc</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The page number. The default value is <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of quintuple rules to return on each page.</para>
        /// <para>The default value is <b>10</b>. The maximum value is <b>50</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The priority of the throttling rule to which the quintuple rule in the QoS policy belongs.</para>
        /// <para>The priority range is 1 to <b>3</b>. A smaller value indicates a higher priority.</para>
        /// <remarks>
        /// <para>If you have submitted a ticket and created a priority-4 QoS policy by calling the <a href="https://help.aliyun.com/document_detail/131575.html">CreateQosPolicy</a> operation, you can use this operation to query the configurations of quintuple rules for the priority-4 QoS policy.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// <para>The ID of the QoS policy instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qos-xitd8690ucu8ro****</para>
        /// </summary>
        [NameInMap("QosId")]
        [Validation(Required=false)]
        public string QosId { get; set; }

        /// <summary>
        /// <para>The ID of the quintuple rule instance in the QoS policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qospy-427m9fo6wkh****</para>
        /// </summary>
        [NameInMap("QosPolicyId")]
        [Validation(Required=false)]
        public string QosPolicyId { get; set; }

        /// <summary>
        /// <para>The ID of the region where the QoS policy instance resides.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
