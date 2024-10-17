// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ListApplicationsResponseBody : TeaModel {
        /// <summary>
        /// <para>The applications.</para>
        /// </summary>
        [NameInMap("Applications")]
        [Validation(Required=false)]
        public List<ListApplicationsResponseBodyApplications> Applications { get; set; }
        public class ListApplicationsResponseBodyApplications : TeaModel {
            /// <summary>
            /// <para>The application name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HDFS</para>
            /// </summary>
            [NameInMap("ApplicationName")]
            [Validation(Required=false)]
            public string ApplicationName { get; set; }

            /// <summary>
            /// <para>The status of the applications. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>STOPPED: At least one application is in the Stopped state.</description></item>
            /// <item><description>RUNNING: All applications are in the Running state.</description></item>
            /// </list>
            /// <para>This parameter is returned only for DataLake, OLAP, Dataflow, DataServing, and custom clusters. For other types of clusters, no value is returned for this parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("ApplicationState")]
            [Validation(Required=false)]
            public string ApplicationState { get; set; }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>The version of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.8.1</para>
            /// </summary>
            [NameInMap("ApplicationVersion")]
            [Validation(Required=false)]
            [Obsolete]
            public string ApplicationVersion { get; set; }

            /// <summary>
            /// <para>The community edition.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.8.5</para>
            /// </summary>
            [NameInMap("CommunityVersion")]
            [Validation(Required=false)]
            public string CommunityVersion { get; set; }

        }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The page number of the next page returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9E3A7161-EB7B-172B-8D18-FFB06BA3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
