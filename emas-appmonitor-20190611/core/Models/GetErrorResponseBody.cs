// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emas_appmonitor20190611.Models
{
    public class GetErrorResponseBody : TeaModel {
        [NameInMap("Args")]
        [Validation(Required=false)]
        public Dictionary<string, object> Args { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public int? ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Model")]
        [Validation(Required=false)]
        public GetErrorResponseBodyModel Model { get; set; }
        public class GetErrorResponseBodyModel : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>4G</para>
            /// </summary>
            [NameInMap("Access")]
            [Validation(Required=false)]
            public string Access { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("AccessSubType")]
            [Validation(Required=false)]
            public string AccessSubType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("AdditionalCallbackInfo")]
            [Validation(Required=false)]
            public string AdditionalCallbackInfo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("AdditionalCrossPlatformCrashInfo")]
            [Validation(Required=false)]
            public string AdditionalCrossPlatformCrashInfo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("AdditionalCustomInfo")]
            [Validation(Required=false)]
            public string AdditionalCustomInfo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("AndroidVm")]
            [Validation(Required=false)]
            public string AndroidVm { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ALIPUBDC3CA71131027</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>appKey</para>
            /// 
            /// <b>Example:</b>
            /// <para>233588686</para>
            /// </summary>
            [NameInMap("AppKey")]
            [Validation(Required=false)]
            public long? AppKey { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>V20250224102631</para>
            /// </summary>
            [NameInMap("AppVersion")]
            [Validation(Required=false)]
            public string AppVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("ArgHash")]
            [Validation(Required=false)]
            public long? ArgHash { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>h=60</para>
            /// </summary>
            [NameInMap("Args")]
            [Validation(Required=false)]
            public string Args { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>java.lang.NullPointerException: Attempt to invoke virtual method \&quot;java.lang.Object</para>
            /// </summary>
            [NameInMap("Backtrace")]
            [Validation(Required=false)]
            public string Backtrace { get; set; }

            /// <summary>
            /// <para>banner</para>
            /// 
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("Banner")]
            [Validation(Required=false)]
            public string Banner { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("BinaryUuids")]
            [Validation(Required=false)]
            public string BinaryUuids { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Hinova</para>
            /// </summary>
            [NameInMap("Brand")]
            [Validation(Required=false)]
            public string Brand { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Chrome</para>
            /// </summary>
            [NameInMap("BrowserName")]
            [Validation(Required=false)]
            public string BrowserName { get; set; }

            [NameInMap("BrowserVersion")]
            [Validation(Required=false)]
            public string BrowserVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Build")]
            [Validation(Required=false)]
            public string Build { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>china</para>
            /// </summary>
            [NameInMap("BusinessCountry")]
            [Validation(Required=false)]
            public string BusinessCountry { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("BusinessErrorExtData")]
            [Validation(Required=false)]
            public string BusinessErrorExtData { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("BusinessLogType")]
            [Validation(Required=false)]
            public string BusinessLogType { get; set; }

            /// <summary>
            /// <para>carrier</para>
            /// 
            /// <b>Example:</b>
            /// <para>CT</para>
            /// </summary>
            [NameInMap("Carrier")]
            [Validation(Required=false)]
            public string Carrier { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ant</para>
            /// </summary>
            [NameInMap("Channel")]
            [Validation(Required=false)]
            public string Channel { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>375</para>
            /// </summary>
            [NameInMap("City")]
            [Validation(Required=false)]
            public string City { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100.104.16.217:51534</para>
            /// </summary>
            [NameInMap("ClientIp")]
            [Validation(Required=false)]
            public string ClientIp { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1739808000000</para>
            /// </summary>
            [NameInMap("ClientTime")]
            [Validation(Required=false)]
            public long? ClientTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ColNo")]
            [Validation(Required=false)]
            public string ColNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CN</para>
            /// </summary>
            [NameInMap("Country")]
            [Validation(Required=false)]
            public string Country { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>arm</para>
            /// </summary>
            [NameInMap("CpuModel")]
            [Validation(Required=false)]
            public string CpuModel { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("CruxModule")]
            [Validation(Required=false)]
            public string CruxModule { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("CruxStack")]
            [Validation(Required=false)]
            public string CruxStack { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("CruxStackHash")]
            [Validation(Required=false)]
            public long? CruxStackHash { get; set; }

            /// <summary>
            /// <para>CruxStackTrace</para>
            /// 
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("CruxStackTrace")]
            [Validation(Required=false)]
            public string CruxStackTrace { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("CruxStackTraceHash")]
            [Validation(Required=false)]
            public long? CruxStackTraceHash { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("CustomExceptionType")]
            [Validation(Required=false)]
            public string CustomExceptionType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("CustomInfo")]
            [Validation(Required=false)]
            public string CustomInfo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("DataDirectory")]
            [Validation(Required=false)]
            public string DataDirectory { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ad-0001t9c1b6y48kqcd44s-105</para>
            /// </summary>
            [NameInMap("DeviceId")]
            [Validation(Required=false)]
            public string DeviceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ASUS_X00GD</para>
            /// </summary>
            [NameInMap("DeviceModel")]
            [Validation(Required=false)]
            public string DeviceModel { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>22jtJ213saqfB1yBgBKhayYPwcZ2</para>
            /// </summary>
            [NameInMap("Did")]
            [Validation(Required=false)]
            public string Did { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>sha256:b3b79f1f6c2beca7ac93a9518a35d542e0bfeb7ae64c9e57e9edd4719489927c</para>
            /// </summary>
            [NameInMap("Digest")]
            [Validation(Required=false)]
            public string Digest { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("DigestHash")]
            [Validation(Required=false)]
            public string DigestHash { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.5</para>
            /// </summary>
            [NameInMap("DomScore")]
            [Validation(Required=false)]
            public string DomScore { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("DownloadCacheDirectory")]
            [Validation(Required=false)]
            public string DownloadCacheDirectory { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>OOM</para>
            /// </summary>
            [NameInMap("ErrorName")]
            [Validation(Required=false)]
            public string ErrorName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>jsError</para>
            /// </summary>
            [NameInMap("ErrorType")]
            [Validation(Required=false)]
            public string ErrorType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0DB-22jtJZzBvqfB1yBgBKhayYPwcZ2</para>
            /// </summary>
            [NameInMap("EventId")]
            [Validation(Required=false)]
            public int? EventId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("EventLog")]
            [Validation(Required=false)]
            public string EventLog { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("ExceptionArg1")]
            [Validation(Required=false)]
            public string ExceptionArg1 { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("ExceptionArg2")]
            [Validation(Required=false)]
            public string ExceptionArg2 { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("ExceptionArg3")]
            [Validation(Required=false)]
            public string ExceptionArg3 { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("ExceptionCode")]
            [Validation(Required=false)]
            public string ExceptionCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("ExceptionCodes")]
            [Validation(Required=false)]
            public string ExceptionCodes { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("ExceptionDetail")]
            [Validation(Required=false)]
            public string ExceptionDetail { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("ExceptionId")]
            [Validation(Required=false)]
            public string ExceptionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Table \&quot;123_temp.image_vw_6191426\&quot; doesn\&quot;t exist</para>
            /// </summary>
            [NameInMap("ExceptionMsg")]
            [Validation(Required=false)]
            public string ExceptionMsg { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("ExceptionSubtype")]
            [Validation(Required=false)]
            public string ExceptionSubtype { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("ExceptionType")]
            [Validation(Required=false)]
            public string ExceptionType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("ExceptionVersion")]
            [Validation(Required=false)]
            public string ExceptionVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>exporting</para>
            /// </summary>
            [NameInMap("ExportStatus")]
            [Validation(Required=false)]
            public string ExportStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("ExternalStorageDirectory")]
            [Validation(Required=false)]
            public string ExternalStorageDirectory { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("FeatureScene")]
            [Validation(Required=false)]
            public string FeatureScene { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>baselineCspm_20241005</para>
            /// </summary>
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dubhe-service/src/main/java/com/viatris/dubhe/monitortask/service/Impl/DataSyncMonitorRecordServiceImpl.java</para>
            /// </summary>
            [NameInMap("FilePath")]
            [Validation(Required=false)]
            public string FilePath { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>chunk-56494f41.3df8bd75.css</para>
            /// </summary>
            [NameInMap("Filename")]
            [Validation(Required=false)]
            public string Filename { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("FlutterRoute")]
            [Validation(Required=false)]
            public string FlutterRoute { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ForceGround")]
            [Validation(Required=false)]
            public int? ForceGround { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ForeGround")]
            [Validation(Required=false)]
            public int? ForeGround { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("H5FullUrl")]
            [Validation(Required=false)]
            public string H5FullUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("H5ShortUrl")]
            [Validation(Required=false)]
            public string H5ShortUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("HasOpenMultiProcessMode")]
            [Validation(Required=false)]
            public int? HasOpenMultiProcessMode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("HasSdCard")]
            [Validation(Required=false)]
            public int? HasSdCard { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("HasSgSecurityConfigKey")]
            [Validation(Required=false)]
            public int? HasSgSecurityConfigKey { get; set; }

            /// <summary>
            /// <para>IMEI</para>
            /// 
            /// <b>Example:</b>
            /// <para>2704b9b0d94b2f3897f82119a1900cd9c7a8108d</para>
            /// </summary>
            [NameInMap("Imei")]
            [Validation(Required=false)]
            public string Imei { get; set; }

            /// <summary>
            /// <para>IMSI</para>
            /// 
            /// <b>Example:</b>
            /// <para>460049842500442</para>
            /// </summary>
            [NameInMap("Imsi")]
            [Validation(Required=false)]
            public string Imsi { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("InMainProcess")]
            [Validation(Required=false)]
            public int? InMainProcess { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("InstallSdCard")]
            [Validation(Required=false)]
            public int? InstallSdCard { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("IsBackTrace")]
            [Validation(Required=false)]
            public int? IsBackTrace { get; set; }

            [NameInMap("IsJailbroken")]
            [Validation(Required=false)]
            public int? IsJailbroken { get; set; }

            [NameInMap("IsSimulator")]
            [Validation(Required=false)]
            public int? IsSimulator { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("IsSpeedVersion")]
            [Validation(Required=false)]
            public int? IsSpeedVersion { get; set; }

            /// <summary>
            /// <para>ISP</para>
            /// 
            /// <b>Example:</b>
            /// <para>cmcc</para>
            /// </summary>
            [NameInMap("Isp")]
            [Validation(Required=false)]
            public string Isp { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>java.lang.NullPointerException: Attempt to invoke virtual method \&quot;java.lang.Object</para>
            /// </summary>
            [NameInMap("JsBacktrace")]
            [Validation(Required=false)]
            public string JsBacktrace { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn</para>
            /// </summary>
            [NameInMap("Language")]
            [Validation(Required=false)]
            public string Language { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-02-25 18:02:50</para>
            /// </summary>
            [NameInMap("LaunchedTime")]
            [Validation(Required=false)]
            public string LaunchedTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("LineNo")]
            [Validation(Required=false)]
            public string LineNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("LogHash")]
            [Validation(Required=false)]
            public long? LogHash { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("MainLog")]
            [Validation(Required=false)]
            public string MainLog { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("MemoryMap")]
            [Validation(Required=false)]
            public string MemoryMap { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("MoreInfo1")]
            [Validation(Required=false)]
            public string MoreInfo1 { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("MoreInfo2")]
            [Validation(Required=false)]
            public string MoreInfo2 { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("MoreInfo3")]
            [Validation(Required=false)]
            public string MoreInfo3 { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("NativeAllThreadDump")]
            [Validation(Required=false)]
            public string NativeAllThreadDump { get; set; }

            /// <summary>
            /// <para>Native map</para>
            /// 
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("NativeMaps")]
            [Validation(Required=false)]
            public string NativeMaps { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("NeedReCluster")]
            [Validation(Required=false)]
            public int? NeedReCluster { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("OpenedFileCount")]
            [Validation(Required=false)]
            public int? OpenedFileCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>[{\&quot;status\&quot;:1,\&quot;target\&quot;:\&quot;5461e0ab-340f-4a6b-9bbe-f75e44985420\&quot;}]</para>
            /// </summary>
            [NameInMap("Operations")]
            [Validation(Required=false)]
            public string Operations { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>[]</para>
            /// </summary>
            [NameInMap("OriginData")]
            [Validation(Required=false)]
            public string OriginData { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("OriginUri")]
            [Validation(Required=false)]
            public string OriginUri { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>android</para>
            /// </summary>
            [NameInMap("Os")]
            [Validation(Required=false)]
            public string Os { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("OsVersion")]
            [Validation(Required=false)]
            public string OsVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{\&quot;Content\&quot;: [], \&quot;TotalPages\&quot;: 2, \&quot;TotalItems\&quot;: 31, \&quot;PageNumber\&quot;: 4, \&quot;PageSize\&quot;: 20}</para>
            /// </summary>
            [NameInMap("Page")]
            [Validation(Required=false)]
            public string Page { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>com.aliyun.demo</para>
            /// </summary>
            [NameInMap("ParentProcessName")]
            [Validation(Required=false)]
            public string ParentProcessName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ce0ak81asd@62706c656a7f1a1</para>
            /// </summary>
            [NameInMap("Pid")]
            [Validation(Required=false)]
            public int? Pid { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>wechat</para>
            /// </summary>
            [NameInMap("Platform")]
            [Validation(Required=false)]
            public string Platform { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("ProcessName")]
            [Validation(Required=false)]
            public string ProcessName { get; set; }

            [NameInMap("Province")]
            [Validation(Required=false)]
            public string Province { get; set; }

            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("ReportContent")]
            [Validation(Required=false)]
            public string ReportContent { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ReportType")]
            [Validation(Required=false)]
            public string ReportType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>720*1280</para>
            /// </summary>
            [NameInMap("Resolution")]
            [Validation(Required=false)]
            public string Resolution { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("RootDirectory")]
            [Validation(Required=false)]
            public string RootDirectory { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("RuntimeExtData")]
            [Validation(Required=false)]
            public string RuntimeExtData { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("SceneValue")]
            [Validation(Required=false)]
            public string SceneValue { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>software_nls_tts_offline_standard</para>
            /// </summary>
            [NameInMap("SdkType")]
            [Validation(Required=false)]
            public string SdkType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5.2.3</para>
            /// </summary>
            [NameInMap("SdkVersion")]
            [Validation(Required=false)]
            public string SdkVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3481243636390427020</para>
            /// </summary>
            [NameInMap("Seq")]
            [Validation(Required=false)]
            public string Seq { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1739808000000</para>
            /// </summary>
            [NameInMap("ServerTime")]
            [Validation(Required=false)]
            public long? ServerTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>9ec8e399-51cc-4283-8ba4-f6df78246249</para>
            /// </summary>
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("SimpleReportContent")]
            [Validation(Required=false)]
            public string SimpleReportContent { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("SoLibBuild")]
            [Validation(Required=false)]
            public string SoLibBuild { get; set; }

            /// <summary>
            /// <para>SpeedFlags</para>
            /// 
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("SpeedFlags")]
            [Validation(Required=false)]
            public string SpeedFlags { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>java.lang.NullPointerException: Attempt to invoke virtual method \&quot;java.lang.Object java.lang.ref.WeakReference.get()\&quot; on a null object reference</para>
            /// </summary>
            [NameInMap("Stack")]
            [Validation(Required=false)]
            public string Stack { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("StructuredStack")]
            [Validation(Required=false)]
            public string StructuredStack { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{\&quot;HandledCheckToday\&quot;: 0, \&quot;RiskCheckCnt\&quot;: 34, \&quot;RiskWarningCnt\&quot;: 57, \&quot;RiskDays\&quot;: 30, \&quot;HandledCheckTotal\&quot;: 5, \&quot;HandledDays\&quot;: 365}</para>
            /// </summary>
            [NameInMap("Summary")]
            [Validation(Required=false)]
            public string Summary { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("SymbolicFileType")]
            [Validation(Required=false)]
            public string SymbolicFileType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("SysLog")]
            [Validation(Required=false)]
            public string SysLog { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("ThreadName")]
            [Validation(Required=false)]
            public string ThreadName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Process Name: \&quot;com.muyuan.mytongdriver\&quot;
            /// Thread Name: \&quot;main\&quot;</para>
            /// </summary>
            [NameInMap("Threads")]
            [Validation(Required=false)]
            public string Threads { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2359</para>
            /// </summary>
            [NameInMap("Tid")]
            [Validation(Required=false)]
            public int? Tid { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("Track")]
            [Validation(Required=false)]
            public string Track { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-02-25 18:02:50</para>
            /// </summary>
            [NameInMap("TriggeredTime")]
            [Validation(Required=false)]
            public string TriggeredTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1740412800000</para>
            /// </summary>
            [NameInMap("UploadTime")]
            [Validation(Required=false)]
            public long? UploadTime { get; set; }

            /// <summary>
            /// <para>URI</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://oss.aliyuncs.com/aliyun_id_photo_bucket/default_handsome.jpg">https://oss.aliyuncs.com/aliyun_id_photo_bucket/default_handsome.jpg</a></para>
            /// </summary>
            [NameInMap("Uri")]
            [Validation(Required=false)]
            public string Uri { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("User")]
            [Validation(Required=false)]
            public string User { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>mark</para>
            /// </summary>
            [NameInMap("UserNick")]
            [Validation(Required=false)]
            public string UserNick { get; set; }

            /// <summary>
            /// <para>utdid</para>
            /// 
            /// <b>Example:</b>
            /// <para>2704b9b0d94b2f3897f82119a</para>
            /// </summary>
            [NameInMap("Utdid")]
            [Validation(Required=false)]
            public string Utdid { get; set; }

            /// <summary>
            /// <para>uuid</para>
            /// 
            /// <b>Example:</b>
            /// <para>105a87c6-f299-42e5-8fc7-1066a47a96e5</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

            /// <summary>
            /// <para>view</para>
            /// 
            /// <b>Example:</b>
            /// <para>com.aliyun.view1</para>
            /// </summary>
            [NameInMap("View")]
            [Validation(Required=false)]
            public string View { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("WeexFullUrl")]
            [Validation(Required=false)]
            public string WeexFullUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("WeexShortUrl")]
            [Validation(Required=false)]
            public string WeexShortUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("WriteLimit")]
            [Validation(Required=false)]
            public int? WriteLimit { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>A8313212-EB4E-4E15-A7F9-D9C8F3FE8E94</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
