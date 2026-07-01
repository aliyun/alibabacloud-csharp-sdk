// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class CreateLiveRecordTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The name of the Live Record Template.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The list of recording formats.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RecordFormat")]
        [Validation(Required=false)]
        public List<CreateLiveRecordTemplateRequestRecordFormat> RecordFormat { get; set; }
        public class CreateLiveRecordTemplateRequestRecordFormat : TeaModel {
            /// <summary>
            /// <para>The duration of a recording cycle in seconds. If you omit this parameter, it defaults to 6 hours.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>If a stream interruption during a recording cycle lasts less than 3 minutes, the recording continues in the same Recording File.</description></item>
            /// </list>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description>A Recording File is finalized only after a stream interruption lasts for more than 3 minutes. To change this default 3-minute threshold, submit a ticket.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>3600</para>
            /// </summary>
            [NameInMap("CycleDuration")]
            [Validation(Required=false)]
            public int? CycleDuration { get; set; }

            /// <summary>
            /// <para>The recording format.</para>
            /// <remarks>
            /// <para>If you set this parameter to <c>m3u8</c>, you must also specify the <c>SliceOssObjectPrefix</c> and <c>SliceDuration</c> parameters.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>m3u8</para>
            /// </summary>
            [NameInMap("Format")]
            [Validation(Required=false)]
            public string Format { get; set; }

            /// <summary>
            /// <para>The name of the Recording File stored in Object Storage Service (OSS).</para>
            /// <list type="bullet">
            /// <item><description><para>The file name must be less than 256 bytes and supports the following variables: {JobId}, {Sequence}, {StartTime}, {EndTime}, {EscapedStartTime}, and {EscapedEndTime}.</para>
            /// </description></item>
            /// <item><description><para>The value must include either the {StartTime} or {EscapedStartTime} variable and either the {EndTime} or {EscapedEndTime} variable.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>record/{JobId}/{Sequence}<em>{EscapedStartTime}</em>{EscapedEndTime}</para>
            /// </summary>
            [NameInMap("OssObjectPrefix")]
            [Validation(Required=false)]
            public string OssObjectPrefix { get; set; }

            /// <summary>
            /// <para>The duration of each slice in seconds.</para>
            /// <remarks>
            /// <para>This parameter is valid only when <c>Format</c> is set to <c>m3u8</c>.</para>
            /// </remarks>
            /// <para>The default value is 30. The value must be an integer from 5 to 30.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("SliceDuration")]
            [Validation(Required=false)]
            public int? SliceDuration { get; set; }

            /// <summary>
            /// <para>The name of the TS slice.</para>
            /// <remarks>
            /// <para>This parameter is required only when <c>Format</c> is set to <c>m3u8</c>.</para>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description><para>The file name must be less than 256 bytes and supports the following variables: {JobId}, {UnixTimestamp}, and {Sequence}.</para>
            /// </description></item>
            /// <item><description><para>The value must include the {UnixTimestamp} and {Sequence} variables.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>record/{JobId}/{UnixTimestamp}_{Sequence}</para>
            /// </summary>
            [NameInMap("SliceOssObjectPrefix")]
            [Validation(Required=false)]
            public string SliceOssObjectPrefix { get; set; }

        }

    }

}
