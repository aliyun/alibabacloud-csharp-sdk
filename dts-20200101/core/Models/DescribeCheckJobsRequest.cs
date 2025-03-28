// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeCheckJobsRequest : TeaModel {
        /// <summary>
        /// <para>Check the task job ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>z9p104ib23***</para>
        /// </summary>
        [NameInMap("CheckJobId")]
        [Validation(Required=false)]
        public string CheckJobId { get; set; }

        /// <summary>
        /// <para>The type of the check</para>
        /// <remarks>
        /// <remarks>
        /// <para>1 full quantity, 2 incremental, 3 all</para>
        /// </remarks>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CheckType")]
        [Validation(Required=false)]
        public int? CheckType { get; set; }

        /// <summary>
        /// <para>Data migration instance ID, which can be queried by calling the <b>describemigrationjobs</b> API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dtsz9p104ib23e972e</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The name of the data migration or synchronization job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zwy_test</para>
        /// </summary>
        [NameInMap("JobName")]
        [Validation(Required=false)]
        public string JobName { get; set; }

        /// <summary>
        /// <para>The number of the page to return. The value must be an integer that is greater than <b>0</b>. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmzawhxxc****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
