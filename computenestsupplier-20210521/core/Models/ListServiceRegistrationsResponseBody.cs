// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class ListServiceRegistrationsResponseBody : TeaModel {
        /// <summary>
        /// <para>Number of items per page in a paginated query. The maximum is 100, and the default is 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. You do not need to specify this parameter for the first request. You must specify the token that is obtained from the previous query as the value of NextToken.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAfu+XtuBE55iRLHEYYuojI4=</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>51945B04-6AA6-410D-93BA-236E0248B104</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Service registration information.</para>
        /// </summary>
        [NameInMap("ServiceRegistrations")]
        [Validation(Required=false)]
        public List<ListServiceRegistrationsResponseBodyServiceRegistrations> ServiceRegistrations { get; set; }
        public class ListServiceRegistrationsResponseBodyServiceRegistrations : TeaModel {
            /// <summary>
            /// <para>Comment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>some info is missing</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>Finish time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-05-23T00:00:00Z</para>
            /// </summary>
            [NameInMap("FinishTime")]
            [Validation(Required=false)]
            public string FinishTime { get; set; }

            /// <summary>
            /// <para>Registration ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sr-001</para>
            /// </summary>
            [NameInMap("RegistrationId")]
            [Validation(Required=false)]
            public string RegistrationId { get; set; }

            /// <summary>
            /// <para>Service ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>service-f4c0026a254bxxxxxxxx</para>
            /// </summary>
            [NameInMap("ServiceId")]
            [Validation(Required=false)]
            public string ServiceId { get; set; }

            /// <summary>
            /// <para>Registration status. Allowed values:</para>
            /// <list type="bullet">
            /// <item><description><para>Submitted</para>
            /// </description></item>
            /// <item><description><para>Approved</para>
            /// </description></item>
            /// <item><description><para>Rejected</para>
            /// </description></item>
            /// <item><description><para>Canceled</para>
            /// </description></item>
            /// <item><description><para>Executed</para>
            /// </description></item>
            /// <item><description><para>Executed: Executed.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Rejected</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>Submit time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-05-22T00:00:00Z</para>
            /// </summary>
            [NameInMap("SubmitTime")]
            [Validation(Required=false)]
            public string SubmitTime { get; set; }

        }

        /// <summary>
        /// <para>Total number of records that meet the criteria.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
