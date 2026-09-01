// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribeProcessStatisticsRequest : TeaModel {
        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b> (default): Chinese.</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The end time of the query for response tasks. The value is a 13-digit UNIX timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>17561XXX77435</para>
        /// </summary>
        [NameInMap("ProcessActionEnd")]
        [Validation(Required=false)]
        public long? ProcessActionEnd { get; set; }

        /// <summary>
        /// <para>The start time of the query for response tasks. The value is a 13-digit UNIX timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>17000XXX83572</para>
        /// </summary>
        [NameInMap("ProcessActionStart")]
        [Validation(Required=false)]
        public long? ProcessActionStart { get; set; }

        /// <summary>
        /// <para>The user ID of the member to which the administrator switches the view.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1709821xxxxx3093</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public string RoleFor { get; set; }

        /// <summary>
        /// <para>The view type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0 (default): the view of the current Alibaba Cloud account.</description></item>
        /// <item><description>1: the view of all accounts in the enterprise.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RoleType")]
        [Validation(Required=false)]
        public string RoleType { get; set; }

    }

}
