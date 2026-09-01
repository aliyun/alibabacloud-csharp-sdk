// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribeSoarTaskAndActionsRequest : TeaModel {
        /// <summary>
        /// <para>The language of the request and response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b> (default): Chinese</para>
        /// </description></item>
        /// <item><description><para><b>en</b>: English</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. The maximum value is 20. If you do not specify this parameter, 10 entries are returned.</para>
        /// <remarks>
        /// <para>Specify a value for this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The trigger type of the task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>stream</b>: The task is triggered by a data stream.</para>
        /// </description></item>
        /// <item><description><para><b>debug</b>: The task is triggered by a debugging process.</para>
        /// </description></item>
        /// <item><description><para><b>manual</b>: The task is triggered manually.</para>
        /// </description></item>
        /// <item><description><para><b>timer</b>: The task is triggered by a timer.</para>
        /// </description></item>
        /// <item><description><para><b>SubInvoke</b>: The task is triggered by a child flow.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>debug</para>
        /// </summary>
        [NameInMap("QueryType")]
        [Validation(Required=false)]
        public string QueryType { get; set; }

        /// <summary>
        /// <para>The input parameter of the playbook.</para>
        /// 
        /// <b>Example:</b>
        /// <para>input</para>
        /// </summary>
        [NameInMap("QueryValue")]
        [Validation(Required=false)]
        public string QueryValue { get; set; }

        /// <summary>
        /// <para>The UUID of the playbook task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1077f2f9-25e8-42d9-bfdf-1528e1313f6d</para>
        /// </summary>
        [NameInMap("RequestUuid")]
        [Validation(Required=false)]
        public string RequestUuid { get; set; }

    }

}
