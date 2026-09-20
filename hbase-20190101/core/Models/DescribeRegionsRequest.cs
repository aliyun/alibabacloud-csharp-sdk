// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class DescribeRegionsRequest : TeaModel {
        /// <summary>
        /// <para>The supported language. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh-CN</b>: Chinese (default)</description></item>
        /// <item><description><b>en-US</b>: English</description></item>
        /// <item><description><b>ja</b>: Japanese.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>The data engine type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>hbase</b>: ApsaraDB for HBase Standard Edition or ApsaraDB for HBase single-node edition.</description></item>
        /// <item><description><b>hbaseue</b>: ApsaraDB for HBase Performance-enhanced Edition.</description></item>
        /// <item><description><b>serverlesshbase</b>: ApsaraDB for HBase Serverless edition.</description></item>
        /// <item><description><b>bds</b>: BDS instance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>hbase</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

    }

}
