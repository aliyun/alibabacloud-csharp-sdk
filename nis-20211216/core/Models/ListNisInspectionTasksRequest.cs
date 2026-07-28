// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nis20211216.Models
{
    public class ListNisInspectionTasksRequest : TeaModel {
        /// <summary>
        /// <para>The name of the network inspection task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NIS inspection</para>
        /// </summary>
        [NameInMap("InspectionName")]
        [Validation(Required=false)]
        public string InspectionName { get; set; }

        /// <summary>
        /// <para>The type of inspection solution that the network inspection task uses. Valid values: basic and customized.</para>
        /// 
        /// <b>Example:</b>
        /// <para>basic</para>
        /// </summary>
        [NameInMap("InspectionProject")]
        [Validation(Required=false)]
        public string InspectionProject { get; set; }

        /// <summary>
        /// <para>The ID of the network inspection task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ni-8svm******hzr7fh79</para>
        /// </summary>
        [NameInMap("InspectionTaskId")]
        [Validation(Required=false)]
        public string InspectionTaskId { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 1 to 100. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that is used to retrieve the next page of results. Set this parameter to the NextToken value returned from a previous call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hKrS+MVXkuOgztXnvdml1/R9jhHkiH8eW3CfaOYU0CEL7yiT0zae6J8v1zYNg+d1</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The running status of the task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Creating</para>
        /// </description></item>
        /// <item><description><para>Active</para>
        /// </description></item>
        /// <item><description><para>Running</para>
        /// </description></item>
        /// <item><description><para>Inactive</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Active</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
