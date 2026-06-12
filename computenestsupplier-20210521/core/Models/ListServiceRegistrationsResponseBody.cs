// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class ListServiceRegistrationsResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of entries returned on each page. Maximum value: 100. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token for the next page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAfu+XtuBE55iRLHEYYuojI4=</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>51945B04-6AA6-410D-93BA-236E0248B104</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The service review request information.</para>
        /// </summary>
        [NameInMap("ServiceRegistrations")]
        [Validation(Required=false)]
        public List<ListServiceRegistrationsResponseBodyServiceRegistrations> ServiceRegistrations { get; set; }
        public class ListServiceRegistrationsResponseBodyServiceRegistrations : TeaModel {
            /// <summary>
            /// <para>The review comments.</para>
            /// 
            /// <b>Example:</b>
            /// <para>some info is missing</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>The end time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-05-23T00:00:00Z</para>
            /// </summary>
            [NameInMap("FinishTime")]
            [Validation(Required=false)]
            public string FinishTime { get; set; }

            /// <summary>
            /// <para>The review request ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sr-001</para>
            /// </summary>
            [NameInMap("RegistrationId")]
            [Validation(Required=false)]
            public string RegistrationId { get; set; }

            /// <summary>
            /// <para>The service ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>service-f4c0026a254bxxxxxxxx</para>
            /// </summary>
            [NameInMap("ServiceId")]
            [Validation(Required=false)]
            public string ServiceId { get; set; }

            /// <summary>
            /// <para>The status of the review request. Possible values:</para>
            /// <list type="bullet">
            /// <item><description><para>Submitted: The request is submitted.</para>
            /// </description></item>
            /// <item><description><para>Approved: The request is approved.</para>
            /// </description></item>
            /// <item><description><para>Rejected: The request is rejected.</para>
            /// </description></item>
            /// <item><description><para>Canceled: The request is canceled.</para>
            /// </description></item>
            /// <item><description><para>Executed: The request is executed.</para>
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
            /// <para>The time when the request was submitted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-05-22T00:00:00Z</para>
            /// </summary>
            [NameInMap("SubmitTime")]
            [Validation(Required=false)]
            public string SubmitTime { get; set; }

        }

        /// <summary>
        /// <para>The total number of matching records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
