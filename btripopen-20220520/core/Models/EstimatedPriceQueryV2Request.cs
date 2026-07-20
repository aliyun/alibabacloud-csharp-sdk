// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class EstimatedPriceQueryV2Request : TeaModel {
        /// <summary>
        /// <para>The category.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>flight</para>
        /// </summary>
        [NameInMap("biz_type")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        /// <summary>
        /// <para>The departure date.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2000-01-01</para>
        /// </summary>
        [NameInMap("depart_date")]
        [Validation(Required=false)]
        public string DepartDate { get; set; }

        /// <summary>
        /// <para>The departure or check-in city.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>杭州</para>
        /// </summary>
        [NameInMap("from_city")]
        [Validation(Required=false)]
        public string FromCity { get; set; }

        /// <summary>
        /// <para>The arrival date.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2000-01-01</para>
        /// </summary>
        [NameInMap("leave_date")]
        [Validation(Required=false)]
        public string LeaveDate { get; set; }

        /// <summary>
        /// <para>The arrival or check-out city.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>北京</para>
        /// </summary>
        [NameInMap("to_city")]
        [Validation(Required=false)]
        public string ToCity { get; set; }

        /// <summary>
        /// <para>The user ID. This parameter is required for the hotel category.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Fei123</para>
        /// </summary>
        [NameInMap("user_id")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
