// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageInstancesRequest : TeaModel {
        /// <summary>
        /// <para>Sets the conditions for searching assets. This parameter is in JSON format and contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><b>name</b>: The search item.</description></item>
        /// <item><description><b>value</b>: The value of the search item.</description></item>
        /// <item><description><b>logicalExp</b>: The logical relationship between multiple search item values. Valid values:<list type="bullet">
        /// <item><description><b>OR</b>: The multiple search item values are in an <b>OR</b> relationship.</description></item>
        /// <item><description><b>AND</b>: The multiple search item values are in an <b>AND</b> relationship.<remarks>
        /// <para>You can call the <a href="~~DescribeImageRepoCriteria~~">DescribeImageRepoCriteria</a> operation to query supported search conditions.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;name&quot;:&quot;instanceId&quot;,&quot;value&quot;:&quot;390100182&quot;,&quot;logicalExp&quot;:&quot;AND&quot;}]</para>
        /// </summary>
        [NameInMap("Criteria")]
        [Validation(Required=false)]
        public string Criteria { get; set; }

        /// <summary>
        /// <para>The page number of the returned results to start displaying. The starting value is <b>1</b>. Default value: <b>1</b>, which indicates that page 1 is displayed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>Sets the logical relationship between multiple search conditions. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>OR</b>: The multiple search conditions are in an <b>OR</b> relationship.</description></item>
        /// <item><description><b>AND</b>: The multiple search conditions are in an <b>AND</b> relationship.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OR</para>
        /// </summary>
        [NameInMap("LogicalExp")]
        [Validation(Required=false)]
        public string LogicalExp { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return on each page during a paged query. The default number of entries per page is 20. If the PageSize parameter is left empty, 20 entries are returned by default.</para>
        /// <remarks>
        /// <para>We recommend that you do not leave the PageSize parameter empty.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Indicates whether the image has been scanned. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: processed.</description></item>
        /// <item><description><b>false</b>: not processed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Scanned")]
        [Validation(Required=false)]
        public bool? Scanned { get; set; }

    }

}
