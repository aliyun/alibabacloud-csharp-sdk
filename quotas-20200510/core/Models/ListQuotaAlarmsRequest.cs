// This file is auto-generated, don't edit it. Thanks.

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Darabonba;
using Darabonba.Utils;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class ListQuotaAlarmsRequest : Darabonba.Model {
        /// <summary>
        /// <para>The name of the quota usage alert.</para>
        /// 
        /// <b>Example:</b>
        /// <para>q_hvnoqv alarm</para>
        /// </summary>
        [NameInMap("AlarmName")]
        [Validation(Required=false)]
        public string AlarmName { get; set; }

        /// <summary>
        /// <para>The maximum number of records to return.</para>
        /// <para>Valid values: 1 to 200. Default value: 30.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that specifies the start point of the query.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the query starts from the beginning.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The abbreviation of the Alibaba Cloud service name.</para>
        /// <remarks>
        /// <para>To obtain the abbreviation of an Alibaba Cloud service name, see the <c>ProductCode</c> parameter in <a href="https://help.aliyun.com/document_detail/440554.html">ListProductQuotas</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ecs</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The quota ID.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>To obtain the quota ID of an Alibaba Cloud service, see the <c>QuotaActionCode</c> parameter in <a href="https://help.aliyun.com/document_detail/440554.html">ListProductQuotas</a>.</para>
        /// </description></item>
        /// <item><description><para>If you specify this parameter, you must also specify <c>ProductCode</c>.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>q_hvnoqv</para>
        /// </summary>
        [NameInMap("QuotaActionCode")]
        [Validation(Required=false)]
        public string QuotaActionCode { get; set; }

        /// <summary>
        /// <para>The quota dimensions.</para>
        /// </summary>
        [NameInMap("QuotaDimensions")]
        [Validation(Required=false)]
        public List<ListQuotaAlarmsRequestQuotaDimensions> QuotaDimensions { get; set; }
        public class ListQuotaAlarmsRequestQuotaDimensions : Darabonba.Model {
            /// <summary>
            /// <para>The key of the quota dimension.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description><para>The number of key-value pairs that you can specify for the quota dimensions varies based on the Alibaba Cloud service.</para>
            /// </description></item>
            /// <item><description><para>If you set <c>ProductCode</c> to <c>ecs</c>, <c>ecs-spec</c>, <c>actiontrail</c>, or <c>ess</c>, you must specify both the key and value for the quota dimension.</para>
            /// </description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>regionId</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the quota dimension.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description><para>The number of key-value pairs that you can specify for the quota dimensions varies based on the Alibaba Cloud service.</para>
            /// </description></item>
            /// <item><description><para>If you set <c>ProductCode</c> to <c>ecs</c>, <c>ecs-spec</c>, <c>actiontrail</c>, or <c>ess</c>, you must specify both the key and value for the quota dimension.</para>
            /// </description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}

