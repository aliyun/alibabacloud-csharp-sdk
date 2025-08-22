// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetRumExceptionStackRequest : TeaModel {
        /// <summary>
        /// <para>The binary images, which represent all executable files loaded into the process address space when a crash occurs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>iOSDemo:arm64%3B1489F4D3-6DE2-300C-90E9-E1B869675351%3B0x0000000104064000\nAlibabaCloudRUM:arm64%3BAB7B3A8E-6CEE-325D-BCBB-8DA50E61804F%3B0x0000000106660000\nlibdispatch.dylib:arm</para>
        /// </summary>
        [NameInMap("ExceptionBinaryImages")]
        [Validation(Required=false)]
        public string ExceptionBinaryImages { get; set; }

        /// <summary>
        /// <para>The exception stack information. Set the value to a JSON string. call_stack.info represents the stack information, call_stack.thread.name represents the thread name, and call_stack.thread.id represents the thread ID. This parameter is exactly the same as the exception.stack parameter in the logstore-rum Logstore of Simple Log Service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[
        /// {
        ///     &quot;call_stack.info&quot;: &quot;libsystem_kernel.dylib  0x00000001f1ce9178 0x00000001f1ce8000 + 4472\r\nlibsystem_kernel.dylib  0x00000001f1ce8f10 0x00000001f1ce8000 + 3856\r\nlibsystem_kernel.dylib  0x00000001f1ced718 0x00000001f1ce8000 + 22296\r\nAlibabaCloudRUM  0x0000000106711af4 0x0000000106660000 + 727796\r\nlibsystem_pthread.dylib  0x00000002146744d4 0x0000000214672000 + 9428&quot;,
        ///     &quot;call_stack.thread.name&quot;: &quot;#3 BRSCrash Exception Handler (Secondary)&quot;,
        ///     &quot;call_stack.thread.id&quot;: &quot;16643&quot;
        ///   }
        /// ]</para>
        /// </summary>
        [NameInMap("ExceptionStack")]
        [Validation(Required=false)]
        public string ExceptionStack { get; set; }

        /// <summary>
        /// <para>The ID of the exception thread.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16643</para>
        /// </summary>
        [NameInMap("ExceptionThreadId")]
        [Validation(Required=false)]
        public string ExceptionThreadId { get; set; }

        /// <summary>
        /// <para>Extra information about iOS symbol tables. You can leave this parameter empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GraphicsServices:system/GraphicsServices/85419099-269B-336D-86B4-0D52D0FF6923/GraphicsServices;WebCore:system/WebCore/BF44A3F4-85D4-38C8-BF26-197F06ADE273/WebCore</para>
        /// </summary>
        [NameInMap("ExtraInfo")]
        [Validation(Required=false)]
        public string ExtraInfo { get; set; }

        /// <summary>
        /// <para>The application ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>atxxxxzkcf@d8deedfa9bf****</para>
        /// </summary>
        [NameInMap("Pid")]
        [Validation(Required=false)]
        public string Pid { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        /// <summary>
        /// <para>The parsing type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>js: Parses JavaScript errors.</description></item>
        /// <item><description>sym: Parses PC errors.</description></item>
        /// <item><description>har: Parses HarmonyOS errors.</description></item>
        /// <item><description>dSYM: Parses iOS errors.</description></item>
        /// <item><description>so: Parses Android errors.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>source-map</para>
        /// </summary>
        [NameInMap("SourcemapType")]
        [Validation(Required=false)]
        public string SourcemapType { get; set; }

        [NameInMap("Workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
