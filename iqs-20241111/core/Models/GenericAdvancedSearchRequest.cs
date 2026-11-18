// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20241111.Models
{
    public class GenericAdvancedSearchRequest : TeaModel {
        /// <summary>
        /// <para>The industry. If you specify this parameter, only website content specific to the specified industry is recalled. Separate multiple industries with commas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>medical</para>
        /// </summary>
        [NameInMap("industry")]
        [Validation(Required=false)]
        public string Industry { get; set; }

        /// <summary>
        /// <para>The search query.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>iPhone</para>
        /// </summary>
        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <para>The session ID for multi-turn interactions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>job-4065bee3-e7aa-49fc-aad2-a8e3a7fd6acd</para>
        /// </summary>
        [NameInMap("sessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>The relative query range for the web page publication time. Valid values: OneDay, OneWeek, OneMonth, OneYear, and NoLimit. A value of NoLimit indicates that no time limit is applied.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OneWeek</para>
        /// </summary>
        [NameInMap("timeRange")]
        [Validation(Required=false)]
        public string TimeRange { get; set; }

    }

}
