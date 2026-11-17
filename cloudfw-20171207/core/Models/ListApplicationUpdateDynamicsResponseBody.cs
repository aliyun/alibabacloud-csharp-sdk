// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class ListApplicationUpdateDynamicsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of update records for the application signature library, sorted in descending order of update time.</para>
        /// </summary>
        [NameInMap("Dynamics")]
        [Validation(Required=false)]
        public List<ListApplicationUpdateDynamicsResponseBodyDynamics> Dynamics { get; set; }
        public class ListApplicationUpdateDynamicsResponseBodyDynamics : TeaModel {
            /// <summary>
            /// <para>The list of applications added or updated in this update.</para>
            /// </summary>
            [NameInMap("Applications")]
            [Validation(Required=false)]
            public List<ListApplicationUpdateDynamicsResponseBodyDynamicsApplications> Applications { get; set; }
            public class ListApplicationUpdateDynamicsResponseBodyDynamicsApplications : TeaModel {
                /// <summary>
                /// <para>The ID of the application in the built-in application signature library.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10012150000</para>
                /// </summary>
                [NameInMap("ApplicationId")]
                [Validation(Required=false)]
                public long? ApplicationId { get; set; }

                /// <summary>
                /// <para>The name of the application. The name is returned in Chinese or English based on the Lang parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DingTalk</para>
                /// </summary>
                [NameInMap("ApplicationName")]
                [Validation(Required=false)]
                public string ApplicationName { get; set; }

            }

            /// <summary>
            /// <para>The update description. The description is returned in Chinese or English based on the Lang parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Added 1 application signature library, such as DingTalk</para>
            /// </summary>
            [NameInMap("DynamicInfo")]
            [Validation(Required=false)]
            public string DynamicInfo { get; set; }

            /// <summary>
            /// <para>The time when the signature library was updated. The value is a UNIX timestamp in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1731465600</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public long? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CBF1E9B7-D6A0-4E9E-AD3E-2B47E6C2837D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of update records that meet the filter conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
