// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class ListApplicationUpdateDynamicsResponseBody : TeaModel {
        [NameInMap("Dynamics")]
        [Validation(Required=false)]
        public List<ListApplicationUpdateDynamicsResponseBodyDynamics> Dynamics { get; set; }
        public class ListApplicationUpdateDynamicsResponseBodyDynamics : TeaModel {
            [NameInMap("Applications")]
            [Validation(Required=false)]
            public List<ListApplicationUpdateDynamicsResponseBodyDynamicsApplications> Applications { get; set; }
            public class ListApplicationUpdateDynamicsResponseBodyDynamicsApplications : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>10012150000</para>
                /// </summary>
                [NameInMap("ApplicationId")]
                [Validation(Required=false)]
                public long? ApplicationId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>钉钉</para>
                /// </summary>
                [NameInMap("ApplicationName")]
                [Validation(Required=false)]
                public string ApplicationName { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>新增钉钉等1个应用特征库</para>
            /// </summary>
            [NameInMap("DynamicInfo")]
            [Validation(Required=false)]
            public string DynamicInfo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1731465600</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public long? PageNo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CBF1E9B7-D6A0-4E9E-AD3E-2B47E6C2837D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
