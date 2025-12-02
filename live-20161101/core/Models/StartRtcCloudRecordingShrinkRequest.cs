// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class StartRtcCloudRecordingShrinkRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>********-7074-<b><b>-9ef5-85c19a4</b></b>*</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>room1024</para>
        /// </summary>
        [NameInMap("ChannelId")]
        [Validation(Required=false)]
        public string ChannelId { get; set; }

        [NameInMap("MaxIdleTime")]
        [Validation(Required=false)]
        public long? MaxIdleTime { get; set; }

        [NameInMap("MixLayoutParams")]
        [Validation(Required=false)]
        public string MixLayoutParamsShrink { get; set; }

        [NameInMap("MixTranscodeParams")]
        [Validation(Required=false)]
        public string MixTranscodeParamsShrink { get; set; }

        [NameInMap("NotifyAuthKey")]
        [Validation(Required=false)]
        public string NotifyAuthKey { get; set; }

        [NameInMap("NotifyFileUploadedFormat")]
        [Validation(Required=false)]
        public List<string> NotifyFileUploadedFormat { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="http://xxxx/test/mycallback">http://xxxx/test/mycallback</a></para>
        /// </summary>
        [NameInMap("NotifyUrl")]
        [Validation(Required=false)]
        public string NotifyUrl { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RecordParams")]
        [Validation(Required=false)]
        public string RecordParamsShrink { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("StorageParams")]
        [Validation(Required=false)]
        public string StorageParamsShrink { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SubscribeParams")]
        [Validation(Required=false)]
        public string SubscribeParamsShrink { get; set; }

    }

}
