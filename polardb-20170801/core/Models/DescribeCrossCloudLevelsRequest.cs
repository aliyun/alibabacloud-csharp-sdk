// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeCrossCloudLevelsRequest : TeaModel {
        /// <summary>
        /// <para>The database engine type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>MySQL</para>
        /// </description></item>
        /// <item><description><para>PostgreSQL</para>
        /// </description></item>
        /// <item><description><para>Oracle</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL</para>
        /// </summary>
        [NameInMap("DBType")]
        [Validation(Required=false)]
        public string DBType { get; set; }

        /// <summary>
        /// <para>The version number of the database engine.</para>
        /// <para>Valid values for MySQL:</para>
        /// <list type="bullet">
        /// <item><description><para>5.6</para>
        /// </description></item>
        /// <item><description><para>5.7</para>
        /// </description></item>
        /// <item><description><para>8.0</para>
        /// </description></item>
        /// </list>
        /// <para>Valid values for PostgreSQL:</para>
        /// <list type="bullet">
        /// <item><description><para>11</para>
        /// </description></item>
        /// <item><description><para>14</para>
        /// </description></item>
        /// <item><description><para>15</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>5.6</para>
        /// </summary>
        [NameInMap("DBVersion")]
        [Validation(Required=false)]
        public string DBVersion { get; set; }

        /// <summary>
        /// <para>The resource pool ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pj-87681rbcef6******</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// <para>The storage class.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SharedStorage</para>
        /// </summary>
        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

    }

}
