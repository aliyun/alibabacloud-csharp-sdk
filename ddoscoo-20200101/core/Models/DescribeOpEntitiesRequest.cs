// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeOpEntitiesRequest : TeaModel {
        /// <summary>
        /// <para>The end of the time range to query. The value is a UNIX timestamp. Unit: milliseconds.</para>
        /// <remarks>
        /// <para>The time must be in the latest 30 days.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1583683200000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The operation object that you want to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>203.<em><b>.</b></em>.132</para>
        /// </summary>
        [NameInMap("EntityObject")]
        [Validation(Required=false)]
        public string EntityObject { get; set; }

        /// <summary>
        /// <para>The type of the operation object that you want to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: the IP address of the Anti-DDoS Pro or Anti-DDoS Premium instance</description></item>
        /// <item><description><b>2</b>: Anti-DDoS plans</description></item>
        /// <item><description><b>3</b>: ECS instances</description></item>
        /// <item><description><b>4</b>: all logs</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("EntityType")]
        [Validation(Required=false)]
        public int? EntityType { get; set; }

        /// <summary>
        /// <para>The number of the page to return. For example, to query the returned results on the first page, set the value to <b>1</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Maximum value: <b>50</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the instance belongs in Resource Management. This parameter is empty by default, which indicates that the instance belongs to the default resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. The value is a UNIX timestamp. Unit: milliseconds.</para>
        /// <remarks>
        /// <para>The time must be in the latest 30 days.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1582992000000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
