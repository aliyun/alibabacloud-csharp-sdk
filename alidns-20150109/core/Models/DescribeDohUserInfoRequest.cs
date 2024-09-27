// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDohUserInfoRequest : TeaModel {
        /// <summary>
        /// <para>The end time for the query. Format: YYYY-MM-DD</para>
        /// <para>If you do not specify this parameter, the default value is the time when you perform the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-07-04</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// <para>The language in which you want the values of some response parameters to be returned. These response parameters support multiple languages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The start time for the query. Format: YYYY-MM-DD</para>
        /// <para>You can query the user information of the last 90 days only. <c>Set the parameter to a value no earlier than 90 days from the current time</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-07-04</para>
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

    }

}
