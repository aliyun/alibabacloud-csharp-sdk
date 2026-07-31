// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyElasticityAssuranceRequest : TeaModel {
        [NameInMap("PrivatePoolOptions")]
        [Validation(Required=false)]
        public ModifyElasticityAssuranceRequestPrivatePoolOptions PrivatePoolOptions { get; set; }
        public class ModifyElasticityAssuranceRequestPrivatePoolOptions : TeaModel {
            /// <summary>
            /// <para>The ID of the elasticity assurance.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eap-bp67acfmxazb4****</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The name of the elasticity assurance. The name must be 2 to 128 characters in length. It must start with a letter or a Chinese character and cannot start with http:// or https://. The name can contain digits, colons (:), underscores (_), or hyphens (-).</para>
            /// 
            /// <b>Example:</b>
            /// <para>eapTestName</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but make sure that the token is unique among different requests. The ClientToken value can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the elasticity assurance. The description must be 2 to 256 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is description.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The total number of instances to be reserved by the elasticity assurance. Valid values: number of used instances to 1000. This parameter cannot be modified together with other parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("InstanceAmount")]
        [Validation(Required=false)]
        public int? InstanceAmount { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The list of recurrence rules for the time-sharing elasticity assurance.</para>
        /// </summary>
        [NameInMap("RecurrenceRules")]
        [Validation(Required=false)]
        public List<ModifyElasticityAssuranceRequestRecurrenceRules> RecurrenceRules { get; set; }
        public class ModifyElasticityAssuranceRequestRecurrenceRules : TeaModel {
            /// <summary>
            /// <para>The end time of the time-sharing assurance. The value must be on the hour.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("EndHour")]
            [Validation(Required=false)]
            public int? EndHour { get; set; }

            /// <summary>
            /// <para>The policy type of the recurrence rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Daily: repeats on a daily basis.</description></item>
            /// <item><description>Weekly: repeats on a weekly basis.</description></item>
            /// <item><description>Monthly: repeats on a monthly basis.</description></item>
            /// </list>
            /// <remarks>
            /// <para>You must specify both <c>RecurrenceType</c> and <c>RecurrenceValue</c>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Daily</para>
            /// </summary>
            [NameInMap("RecurrenceType")]
            [Validation(Required=false)]
            public string RecurrenceType { get; set; }

            /// <summary>
            /// <para>The value of the recurrence rule.</para>
            /// <list type="bullet">
            /// <item><description>If <c>RecurrenceType</c> is set to <c>Daily</c>, you can specify only one value. Valid values: 1 to 31. The value specifies the interval in days between recurrences.</description></item>
            /// <item><description>If <c>RecurrenceType</c> is set to <c>Weekly</c>, you can specify multiple values separated by commas (,). The values for Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, and Saturday are 0, 1, 2, 3, 4, 5, and 6. For example, <c>1,2</c> specifies Monday and Tuesday.</description></item>
            /// <item><description>If <c>RecurrenceType</c> is set to <c>Monthly</c>, the format is <c>A-B</c>. Valid values of A and B: 1 to 31. B must be greater than or equal to A. For example, <c>1-5</c> specifies the 1st to 5th day of each month.</description></item>
            /// </list>
            /// <remarks>
            /// <para>You must specify both <c>RecurrenceType</c> and <c>RecurrenceValue</c>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("RecurrenceValue")]
            [Validation(Required=false)]
            public string RecurrenceValue { get; set; }

            /// <summary>
            /// <para>The effective period start time of the time-sharing assurance. The value must be on the hour.</para>
            /// <remarks>
            /// <para>You must specify both <c>StartHour</c> and <c>EndHour</c>, and the difference between them must be at least 4 hours.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("StartHour")]
            [Validation(Required=false)]
            public int? StartHour { get; set; }

        }

        /// <summary>
        /// <para>The region ID of the elasticity assurance. You can call <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> to query the most recent region list.</para>
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
