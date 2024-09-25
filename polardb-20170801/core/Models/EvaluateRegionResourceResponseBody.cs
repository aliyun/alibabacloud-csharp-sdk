// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class EvaluateRegionResourceResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether sufficient resources are available. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DBInstanceAvailable")]
        [Validation(Required=false)]
        public string DBInstanceAvailable { get; set; }

        /// <summary>
        /// <para>The type of the database engine. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>MySQL</b></description></item>
        /// <item><description><b>PostgreSQL</b></description></item>
        /// <item><description><b>Oracle</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL</para>
        /// </summary>
        [NameInMap("DBType")]
        [Validation(Required=false)]
        public string DBType { get; set; }

        /// <summary>
        /// <para>The version of the database engine</para>
        /// <list type="bullet">
        /// <item><description><para>Valid values for the MySQL database engine:</para>
        /// <list type="bullet">
        /// <item><description><b>5.6</b></description></item>
        /// <item><description><b>5.7</b></description></item>
        /// <item><description><b>8.0</b></description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Valid values for the PostgreSQL database engine:</para>
        /// <list type="bullet">
        /// <item><description><b>11</b></description></item>
        /// <item><description><b>14</b></description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Valid value for the Oracle database engine: <b>11</b></para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>8.0</para>
        /// </summary>
        [NameInMap("DBVersion")]
        [Validation(Required=false)]
        public string DBVersion { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>69A85BAF-1089-4CDF-A82F-0A140F******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
