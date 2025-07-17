// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetRumExceptionStackResponseBody : TeaModel {
        /// <summary>
        /// <para>The responses code. The status code 200 indicates that the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetRumExceptionStackResponseBodyData Data { get; set; }
        public class GetRumExceptionStackResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The name and UUID of the symbol table required for parsing the exception stack. This parameter is exposed during the parsing of PC errors.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;04B5B216682E40BF9BBE9698E3F98CAA0,libcurl.4.dylib;7878DB3CF21A3C13A203B7E3B0FA66250,libalibabacloud_rum.dylib;0F9F96FE6B1C3253A33AC9E4A0C2A3860,libsystem_kernel.dylib;3DF3256F466E37BCB995A5A9956E14150,libsystem_pthread.dylib;000000000000000000000000000000000,Security;EA4B83A319EB3E15B22CDF035DBD49250,alibabacloud_rum_example;710BB12EEEC744BAB41D1849CA3AD8021,LTSDK.pdb;EE330BA9C49E4730AA15A2B7C0BB2CAE1,JBLive.pdb&quot;</para>
            /// </summary>
            [NameInMap("BinaryImages")]
            [Validation(Required=false)]
            public string BinaryImages { get; set; }

            /// <summary>
            /// <para>The crash address. This parameter is exposed during the parsing of PC errors.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0x1</para>
            /// </summary>
            [NameInMap("CrashAddress")]
            [Validation(Required=false)]
            public string CrashAddress { get; set; }

            /// <summary>
            /// <para>The cause of the exception. This parameter is exposed during the parsing of PC errors.</para>
            /// 
            /// <b>Example:</b>
            /// <para>EXC_BAD_ACCESS / KERN_INVALID_ADDRESS</para>
            /// </summary>
            [NameInMap("CrashReason")]
            [Validation(Required=false)]
            public string CrashReason { get; set; }

            /// <summary>
            /// <para>The list of stacks.</para>
            /// </summary>
            [NameInMap("Lines")]
            [Validation(Required=false)]
            public List<string> Lines { get; set; }

            /// <summary>
            /// <para>The name of the crash parsing module. This parameter is exposed during the parsing of PC errors.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alibabacloud_rum_example</para>
            /// </summary>
            [NameInMap("ModuleName")]
            [Validation(Required=false)]
            public string ModuleName { get; set; }

            /// <summary>
            /// <para>The thread ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16643</para>
            /// </summary>
            [NameInMap("ThreadId")]
            [Validation(Required=false)]
            public string ThreadId { get; set; }

            /// <summary>
            /// <para>The thread stack information captured during PC crashes.</para>
            /// </summary>
            [NameInMap("ThreadInfoList")]
            [Validation(Required=false)]
            public List<GetRumExceptionStackResponseBodyDataThreadInfoList> ThreadInfoList { get; set; }
            public class GetRumExceptionStackResponseBodyDataThreadInfoList : TeaModel {
                /// <summary>
                /// <para>Thread stack details.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;0  libsystem_platform.dylib + 0x1ab5\n    rax = 0x0000000000000001   rdx = 0x0000000000000064\n    rcx = 0xffffffffffffffff   rbx = 0x0000000107701bd0\n    rsi = 0x0101010101010101   rdi = 0x0000000000000001\n    rbp = 0x00007ff7b8d64300   rsp = 0x00007ff7b8d64300\n     r8 = 0x000000000000000a    r9 = 0x0000000000000000\n    r10 = 0x0000000000000001   r11 = 0x0000000000000247\n    r12 = 0x00007ff7b8d64390   r13 = 0x0000000000000000\n    r14 = 0x000000010719d770   r15 = 0x00007ff7b8d64500\n    rip = 0x00007ff807a40ab5\n    Found by: given as instruction pointer in context\n 1  alibabacloud_rum_example + 0x2ad1\n    rbp = 0x00007ff7b8d64310   rsp = 0x00007ff7b8d64310\n    rip = 0x000000010719dad1\n    Found by: previous frame\&quot;s frame pointer\n 2  alibabacloud_rum_example + 0x2a3b\n    rbp = 0x00007ff7b8d64360   rsp = 0x00007ff7b8d64320\n    rip = 0x000000010719da3b\n    Found by: previous frame\&quot;s frame pointer\n 3  0x7ff807688345\n    rbp = 0x00007ff7b8d64580   rsp = 0x00007ff7b8d64370\n    rip = 0x00007ff807688345\n    Found by: previous frame\&quot;s frame pointer&quot;</para>
                /// </summary>
                [NameInMap("ThreadDetail")]
                [Validation(Required=false)]
                public string ThreadDetail { get; set; }

                /// <summary>
                /// <para>The thread tag, including the thread number and name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Thread 0 (crashed)</para>
                /// </summary>
                [NameInMap("ThreadTag")]
                [Validation(Required=false)]
                public string ThreadTag { get; set; }

            }

            /// <summary>
            /// <para>The UUID of the symbol table required for parsing the stack. This parameter is exposed during the parsing of PC errors.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9032259CEB9130E780C6DE8FDECCD7990</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public string HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Internal error. Please try again. Contact the DingTalk service account if the issue                              persists after multiple retries.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B6A00968-82A8-4F14-9D1B-B53827DB****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c></description></item>
        /// <item><description><c>false</c></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
