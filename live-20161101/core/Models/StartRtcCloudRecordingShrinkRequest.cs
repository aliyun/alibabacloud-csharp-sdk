// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class StartRtcCloudRecordingShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the app to which the channel to be recorded belongs. The app must belong to the primary account associated with the current API caller\&quot;s account.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>********-7074-<b><b>-9ef5-85c19a4</b></b>*</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The ID of the channel to be recorded. Make sure that the channel has active users when you call this operation. Otherwise, the recording task fails to be created.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>room1024</para>
        /// </summary>
        [NameInMap("ChannelId")]
        [Validation(Required=false)]
        public string ChannelId { get; set; }

        /// <summary>
        /// <para>The idle timeout period. When the task remains idle for longer than MaxIdleTime, the task is automatically stopped. Unit: seconds. The value must be within [10,14400], which is a maximum of 4 hours. Default value: 300.</para>
        /// 
        /// <b>Example:</b>
        /// <para>600</para>
        /// </summary>
        [NameInMap("MaxIdleTime")]
        [Validation(Required=false)]
        public long? MaxIdleTime { get; set; }

        /// <summary>
        /// <para>The layout parameters. This parameter is not required in single-stream recording mode and is required in stream mixing recording mode when the output is not audio-only.</para>
        /// </summary>
        [NameInMap("MixLayoutParams")]
        [Validation(Required=false)]
        public string MixLayoutParamsShrink { get; set; }

        /// <summary>
        /// <para>The transcoding parameters. This parameter is not required in single-stream recording mode and is required in stream mixing recording mode.</para>
        /// </summary>
        [NameInMap("MixTranscodeParams")]
        [Validation(Required=false)]
        public string MixTranscodeParamsShrink { get; set; }

        /// <summary>
        /// <para>The authentication key for callback messages. Leave this parameter empty to skip authentication. If specified, the key must be 16 to 64 characters in length and consist of only uppercase and lowercase letters and digits.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mytestkeymytestkey</para>
        /// </summary>
        [NameInMap("NotifyAuthKey")]
        [Validation(Required=false)]
        public string NotifyAuthKey { get; set; }

        /// <summary>
        /// <para>The specified formats for which a callback message is sent when the recording file upload event (RecordFileUploaded) is triggered.</para>
        /// </summary>
        [NameInMap("NotifyFileUploadedFormat")]
        [Validation(Required=false)]
        public List<string> NotifyFileUploadedFormat { get; set; }

        /// <summary>
        /// <para>The URL for receiving callback messages. Task status messages are pushed to this URL in JSON format by using the POST method. The maximum length is 2048 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://xxxx/test/mycallback">http://xxxx/test/mycallback</a></para>
        /// </summary>
        [NameInMap("NotifyUrl")]
        [Validation(Required=false)]
        public string NotifyUrl { get; set; }

        /// <summary>
        /// <para>The recording parameters.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RecordParams")]
        [Validation(Required=false)]
        public string RecordParamsShrink { get; set; }

        /// <summary>
        /// <para>The storage parameters.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("StorageParams")]
        [Validation(Required=false)]
        public string StorageParamsShrink { get; set; }

        /// <summary>
        /// <para>The subscription parameters.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SubscribeParams")]
        [Validation(Required=false)]
        public string SubscribeParamsShrink { get; set; }

    }

}
