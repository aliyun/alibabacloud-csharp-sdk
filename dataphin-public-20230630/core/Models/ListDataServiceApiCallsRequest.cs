// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListDataServiceApiCallsRequest : TeaModel {
        /// <summary>
        /// <para>The query conditions.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ListQuery")]
        [Validation(Required=false)]
        public ListDataServiceApiCallsRequestListQuery ListQuery { get; set; }
        public class ListDataServiceApiCallsRequestListQuery : TeaModel {
            /// <summary>
            /// <para>The ID of the API.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20122</para>
            /// </summary>
            [NameInMap("ApiId")]
            [Validation(Required=false)]
            public long? ApiId { get; set; }

            /// <summary>
            /// <para>The name of the API.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("ApiName")]
            [Validation(Required=false)]
            public string ApiName { get; set; }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>The application key.</para>
            /// <remarks>
            /// <para>Notice: This parameter is deprecated. Use AppKeyStr instead.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>12345</para>
            /// </summary>
            [NameInMap("AppKey")]
            [Validation(Required=false)]
            [Obsolete]
            public long? AppKey { get; set; }

            /// <summary>
            /// <para>The application key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>app12345</para>
            /// </summary>
            [NameInMap("AppKeyStr")]
            [Validation(Required=false)]
            public string AppKeyStr { get; set; }

            /// <summary>
            /// <para>The IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.1.1</para>
            /// </summary>
            [NameInMap("ClientIp")]
            [Validation(Required=false)]
            public string ClientIp { get; set; }

            /// <summary>
            /// <para>The end time. Format: yyyy-MM-dd HH:mm:ss.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-06-30 20:00:00</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The page number. Default value: 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public int? PageNo { get; set; }

            /// <summary>
            /// <para>The number of entries per page. Default value: 20.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The start time. Format: yyyy-MM-dd HH:mm:ss.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-06-30 08:00:00</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>Indicates whether the call was successful.</para>
            /// </summary>
            [NameInMap("Successful")]
            [Validation(Required=false)]
            public bool? Successful { get; set; }

        }

        /// <summary>
        /// <para>The ID of the tenant.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

        /// <summary>
        /// <para>The ID of the data service project.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>102102</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public int? ProjectId { get; set; }

    }

}
