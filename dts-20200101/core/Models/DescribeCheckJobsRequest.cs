// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeCheckJobsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the data validation task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>z9p104ib23***</para>
        /// </summary>
        [NameInMap("CheckJobId")]
        [Validation(Required=false)]
        public string CheckJobId { get; set; }

        /// <summary>
        /// <para>The data validation method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: full data validation.</description></item>
        /// <item><description><b>2</b>: incremental data validation.</description></item>
        /// <item><description><b>3</b>: all.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CheckType")]
        [Validation(Required=false)]
        public int? CheckType { get; set; }

        /// <summary>
        /// <para>The ID of the data migration instance. You can call the <b>DescribeMigrationJobs</b> operation to query the ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dtsz9p104ib23e972e</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The name of the data migration or data synchronization task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zwy_test</para>
        /// </summary>
        [NameInMap("JobName")]
        [Validation(Required=false)]
        public string JobName { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of records per page. Valid values: <b>30</b>, <b>50</b>, and <b>100</b>. Default value: <b>30</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmzawhxxc****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
