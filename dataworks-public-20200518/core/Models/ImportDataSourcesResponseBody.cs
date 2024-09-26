// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ImportDataSourcesResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the imported data sources.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ImportDataSourcesResponseBodyData Data { get; set; }
        public class ImportDataSourcesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The reason why the data sources failed to be imported. If the data sources were imported, this parameter is left empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Data source DEV XXX already exists</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>Indicates whether the data sources were imported. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: All data sources were imported.</description></item>
            /// <item><description>false: Specific data sources failed to be imported. You can troubleshoot issues based on the Message parameter.</description></item>
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
        /// <para>The request ID. You can locate logs and troubleshoot issues based on the ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0bc1411515937635973****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
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
