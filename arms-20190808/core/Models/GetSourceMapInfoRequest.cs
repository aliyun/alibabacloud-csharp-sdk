// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetSourceMapInfoRequest : TeaModel {
        /// <summary>
        /// <para>The order in which the files are sorted. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: ascending order</description></item>
        /// <item><description>false: descending order</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AscendingSequence")]
        [Validation(Required=false)]
        public bool? AscendingSequence { get; set; }

        /// <summary>
        /// <para>The version of the SourceMap file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.0.0</para>
        /// </summary>
        [NameInMap("Edition")]
        [Validation(Required=false)]
        public string Edition { get; set; }

        /// <summary>
        /// <para>The ID of the SourceMap file.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ID")]
        [Validation(Required=false)]
        public string ID { get; set; }

        /// <summary>
        /// <para>The keyword in the file name. The files are searched by keyword.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The criterion by which the files are sorted. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>version: The files are sorted by version.</description></item>
        /// <item><description>uploadTime: The files are sorted by upload time.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>version</para>
        /// </summary>
        [NameInMap("OrderField")]
        [Validation(Required=false)]
        public string OrderField { get; set; }

        /// <summary>
        /// <para>The ID of the region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
