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
            /// <para>The name of the elasticity assurance. The name must be 2 to 128 characters in length. The name must start with a letter and cannot start with http:// or https://. The name can contain digits, colons (:), underscores (_), and hyphens (-).</para>
            /// 
            /// <b>Example:</b>
            /// <para>eapTestName</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
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
        /// <para>The total number of instances for which you want to reserve capacity. Valid values: the number of created instances to 1000. This parameter is mutually exclusive with other parameters in the same request.</para>
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
        /// <para>The assurance schedules of the time-segmented elasticity assurance.</para>
        /// <remarks>
        /// <para> Time-segmented elasticity assurances are available only in specific regions and to specific users. To use time-segmented elasticity assurances, <a href="https://smartservice.console.aliyun.com/service/create-ticket-intl">submit a ticket</a>.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("RecurrenceRules")]
        [Validation(Required=false)]
        public List<ModifyElasticityAssuranceRequestRecurrenceRules> RecurrenceRules { get; set; }
        public class ModifyElasticityAssuranceRequestRecurrenceRules : TeaModel {
            /// <summary>
            /// <para>The end time of the assurance period for the capacity reservation of the time-segmented elasticity assurance. Specify an on-the-hour point in time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("EndHour")]
            [Validation(Required=false)]
            public int? EndHour { get; set; }

            /// <summary>
            /// <para>The type of the assurance schedule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Daily</description></item>
            /// <item><description>Weekly</description></item>
            /// <item><description>Monthly</description></item>
            /// </list>
            /// <remarks>
            /// <para> If you specify this parameter, you must specify <c>RecurrenceType</c> and <c>RecurrenceValue</c>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Daily</para>
            /// </summary>
            [NameInMap("RecurrenceType")]
            [Validation(Required=false)]
            public string RecurrenceType { get; set; }

            /// <summary>
            /// <para>The days of the week or month on which the capacity reservation of the time-segmented elasticity assurance takes effect or the interval, in number of days, at which the capacity reservation takes effect.</para>
            /// <list type="bullet">
            /// <item><description>If you set <c>RecurrenceType</c> to <c>Daily</c>, you can specify only one value. Valid values: 1 to 31. The value specifies that the capacity reservation takes effect every few days.</description></item>
            /// <item><description>If you set <c>RecurrenceType</c> to <c>Weekly</c>, you can specify multiple values. Separate the values with commas (,). Valid values: 0, 1, 2, 3, 4, 5, and 6, which specify Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, and Saturday, respectively. Example: <c>1,2</c>, which specifies that the capacity reservation takes effect on Monday and Tuesday.</description></item>
            /// <item><description>If you set <c>RecurrenceType</c> to <c>Monthly</c>, you can specify two values in the <c>A-B</c> format. Valid values of A and B: 1 to 31. B must be greater than or equal to A. Example: <c>1-5</c>, which specifies that the capacity reservation takes effect every day from the first day up to the fifth day of each month.</description></item>
            /// </list>
            /// <remarks>
            /// <para> If this parameter is specified, you must specify <c>RecurrenceType</c> and <c>RecurrenceValue</c>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("RecurrenceValue")]
            [Validation(Required=false)]
            public string RecurrenceValue { get; set; }

            /// <summary>
            /// <para>The start time of the assurance period for the capacity reservation of the time-segmented elasticity assurance. Specify an on-the-hour point in time.</para>
            /// <remarks>
            /// <para> You must specify both <c>StartHour</c> and <c>EndHour</c>. The EndHour value must be at least 4 hours later than the StartHour value.</para>
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
        /// <para>The region ID of the elasticity assurance. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the most recent region list.</para>
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
