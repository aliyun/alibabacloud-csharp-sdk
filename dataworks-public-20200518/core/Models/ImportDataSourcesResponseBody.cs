// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ImportDataSourcesResponseBody : TeaModel {
        /// <summary>
        /// <para>The result of importing data sources in batches.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ImportDataSourcesResponseBodyData Data { get; set; }
        public class ImportDataSourcesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The description of the cause for the failure to import data sources in batches. If the data sources are successfully imported, this parameter is left empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Data source DEV XXX already exists</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>Indicates whether all data sources are successfully imported. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: All data sources are successfully imported.</description></item>
            /// <item><description>false: Some data sources fail to be imported. You can check the Message parameter to locate the cause of the failure.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public bool? Status { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request. You can use the ID to locate logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0bc1411515937635973****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The request is successful.</description></item>
        /// <item><description>false: The request fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
