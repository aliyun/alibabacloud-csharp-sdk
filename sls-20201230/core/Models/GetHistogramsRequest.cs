// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class GetHistogramsRequest : TeaModel {
        /// <summary>
        /// <para>The start time of the subinterval. The value is a UNIX timestamp representing the number of seconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1409529600</para>
        /// </summary>
        [NameInMap("from")]
        [Validation(Required=false)]
        public long? From { get; set; }

        /// <summary>
        /// <para>The search statement. Only search statements are supported. Analytic statements are not supported. For more information about the syntax of search statements, see <a href="https://help.aliyun.com/document_detail/43772.html">Log search overview</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>with_pack_meta</para>
        /// </summary>
        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <para>The end time of the subinterval. The value is a UNIX timestamp representing the number of seconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1409569200</para>
        /// </summary>
        [NameInMap("to")]
        [Validation(Required=false)]
        public long? To { get; set; }

        /// <summary>
        /// <para>The topic of the logs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>topic</para>
        /// </summary>
        [NameInMap("topic")]
        [Validation(Required=false)]
        public string Topic { get; set; }

    }

}
