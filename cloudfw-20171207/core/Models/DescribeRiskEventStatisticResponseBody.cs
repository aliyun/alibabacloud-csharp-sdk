// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeRiskEventStatisticResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of attacked applications.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("AttackAppCnt")]
        [Validation(Required=false)]
        public int? AttackAppCnt { get; set; }

        /// <summary>
        /// <para>The attack count.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("AttackCnt")]
        [Validation(Required=false)]
        public int? AttackCnt { get; set; }

        /// <summary>
        /// <para>The number of attacked assets.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("AttackIpCnt")]
        [Validation(Required=false)]
        public int? AttackIpCnt { get; set; }

        /// <summary>
        /// <para>The drop count.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("DropCnt")]
        [Validation(Required=false)]
        public int? DropCnt { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F93A490D-9E92-5AA4-BA79-600FFC09****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
