// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BDRC20230808.Models
{
    public class ListMessagesRequest : TeaModel {
        /// <summary>
        /// <para>The maximum number of records to return in this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>Message level.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WARNING</para>
        /// </summary>
        [NameInMap("MessageLevel")]
        [Validation(Required=false)]
        public string MessageLevel { get; set; }

        /// <summary>
        /// <para>Messages with time earlier than this value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1740019610</para>
        /// </summary>
        [NameInMap("MessageTimeEarlierThan")]
        [Validation(Required=false)]
        public long? MessageTimeEarlierThan { get; set; }

        /// <summary>
        /// <para>Messages with time later than this value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1740019609</para>
        /// </summary>
        [NameInMap("MessageTimeLaterThan")]
        [Validation(Required=false)]
        public long? MessageTimeLaterThan { get; set; }

        /// <summary>
        /// <para>Message type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUB_PROTECTION_POLICY_MODIFIED</para>
        /// </summary>
        [NameInMap("MessageType")]
        [Validation(Required=false)]
        public string MessageType { get; set; }

        /// <summary>
        /// <para>The pagination token. If more entries are to be returned on the next page, a pagination token is returned.</para>
        /// <remarks>
        /// <para>If this parameter returns data, it indicates that there are more pages. You can use the returned NextToken as a request parameter to obtain the next page of data until it returns Null, indicating that all data has been obtained.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cae***********99</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
