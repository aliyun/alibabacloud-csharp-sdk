// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeAppsByApiProductResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about authorized applications.</para>
        /// </summary>
        [NameInMap("AuthorizedApps")]
        [Validation(Required=false)]
        public DescribeAppsByApiProductResponseBodyAuthorizedApps AuthorizedApps { get; set; }
        public class DescribeAppsByApiProductResponseBodyAuthorizedApps : TeaModel {
            [NameInMap("AuthorizedApp")]
            [Validation(Required=false)]
            public List<DescribeAppsByApiProductResponseBodyAuthorizedAppsAuthorizedApp> AuthorizedApp { get; set; }
            public class DescribeAppsByApiProductResponseBodyAuthorizedAppsAuthorizedApp : TeaModel {
                /// <summary>
                /// <para>The application ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>110982419</para>
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public long? AppId { get; set; }

                /// <summary>
                /// <para>The application name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>APP_02580_DEV</para>
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// <para>The expiration time of the authorization. The time is in GMT. An empty value indicates that the authorization does not expire.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-06-17T03:41:53Z</para>
                /// </summary>
                [NameInMap("AuthValidTime")]
                [Validation(Required=false)]
                public string AuthValidTime { get; set; }

                /// <summary>
                /// <para>The time when the authorization was created. The time is in GMT.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2016-07-21T06:17:20Z</para>
                /// </summary>
                [NameInMap("AuthorizedTime")]
                [Validation(Required=false)]
                public string AuthorizedTime { get; set; }

                /// <summary>
                /// <para>The authorization description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test share with nsc qiming</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The extended information.</para>
                /// 
                /// <b>Example:</b>
                /// <para>extra info</para>
                /// </summary>
                [NameInMap("Extend")]
                [Validation(Required=false)]
                public string Extend { get; set; }

            }

        }

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
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AC866798-62D3-52F4-8AB5-CA149A53984F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of returned entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
